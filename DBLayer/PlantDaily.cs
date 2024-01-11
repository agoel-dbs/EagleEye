using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.Data;

namespace EagleEye.DBLayer
{
    class PlantDaily
    {
        public string DailyDate { get; set; }
        public string CreatedBy { get; set; }

        public string logicalError = "99~";
        public string logicalOK = "1~";
        public string TechnicalError = "100~";


        public string CheckDailyAlreadyExists()
        {
            string strReturn;
            string strMsg;
            DataTable Dt;
            string strSql = "";
            Dictionary<string, string> Params = new Dictionary<string, string>() { };
            // if adding new user check if user Id Already Exists
            try
            {
                strSql = "select count(1) from daily_details where tran_date = @DailyDate";

                Params.Add("DailyDate", DailyDate.ToString());
                DbConnectionFactory dbObj = new DbConnectionFactory();
                strReturn = dbObj.ExecuteScalerQuery(strSql, Params); 
                return strReturn;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        // generate daily records

        public string GenerateDaily()
        {
            int iRevNo;
            string strReturn;
            decimal dOutstandingBal;
            decimal dClosingBal;
            decimal dTotalCreditAmount;
            decimal dTotalDebitAmount;

            string ProcessName = "GenerateDaily";

            DbConnectionFactory objFactory = new DbConnectionFactory();
            // Start a local transaction
            objFactory.TransConnection();
            objFactory.TransCommand();
            objFactory.TransBegin();
            objFactory.TransAttachCommand();
            string strSql;
            Dictionary<string, string> Params = new Dictionary<string, string>() { };

            try
            {
                // get the Opening Balance and make and entry

                // first check the latest revision no for the daily date
                strSql = "select " + Global.gIsNull  + " (max(rev_no),-1) from daily_details " +
                                  "where tran_date= @DailyDate";
                Params.Add("DailyDate", DailyDate.ToString());
                iRevNo = commonLib.fnCheckNull((objFactory.TransExecuteScalerQuery(strSql,Params).ToString()));

                // invalidate old revision record

                strSql= "update daily_details set is_active = 0 " +
                                   ",updated_by = @CreatedBy , updated_on = CURRENT_TIMESTAMP " +
                                  " where tran_date = @DailyDate and rev_no <= @RevNo ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql,Params);

                // update revision no with nextno
                iRevNo = iRevNo + 1;

                // get the Opening Balance from ledger account multiply with -1  so that Credit figure is shown as +

                strSql = " select round(" + Global.gIsNull + "(sum(ledger_amt * -1),0),0) from vw_ledger_account " +
                                  " where tran_head = 'CASH' and tran_date < @DailyDate ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                dOutstandingBal = commonLib.fnCheckDecimal((objFactory.TransExecuteScalerQuery(strSql,Params).ToString()));

                // make an entry in db for Opening Balance
                strSql = " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " values " +
                                 " (@DailyDate,'OB','C/F','Opening Balance','',@OutstandingBal,@RevNo,@CreatedBy,@CreatedBy) ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("OutstandingBal", dOutstandingBal.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql ,Params);


                // incoming Funds (Sale or payment Received or Vendor payment made in -ve)

                //cash sale
                strSql = " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " select TRAN_DATE, 'AR' REC_TYPE , TRAN_SOURCE REC_DESC, t3.Name DESCRIPTION, TRAN_SUB_HEAD SUB_DESC " +
                                " ,sum((ledger_AMT * -1)) LEDGER_AMT ,@RevNo,@CreatedBy,@CreatedBy " +
                                " from VW_LEDGER_ACCOUNT t1 " +
                                " left outer join vw_invoice_header t2 on (t1.SOURCE_RK = t2.INVOICE_RK)" +
                                " left OUTER join BUYER_MASTER t3 on t2.BUYER_RK = t3.BUYER_RK " +
                                " where TRAN_HEAD = 'CASH' and t1.TRAN_SOURCE = 'Invoice' and t1.TRAN_SUB_HEAD = 'Customer Payment'" +
                                " and t1.tran_date = @DailyDate group by t1.TRAN_DATE,TRAN_SOURCE ,t3.Name ,TRAN_SUB_HEAD";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // Old Payment Received

                strSql= " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " select t1.tran_date, 'AR' rec_type , tran_source rec_desc, t5.name description, tran_sub_head sub_Desc " +
                                 " ,sum((ledger_AMT * -1)) ledger_amt, @RevNo,@CreatedBy,@CreatedBy " +
                                " from vw_ledger_account t1 " +
                                " left outer join inward_remittance t4 on (t1.source_rk = t4.inward_rk)" +
                                " left OUTER join buyer_master t5 on t4.buyer_rk = t5.buyer_rk" +
                                " where tran_head = 'CASH' and t1.tran_Source = 'Inward Remittance'" +
                                " and t1.tran_date = @DailyDate group by t1.tran_date,t1.tran_source ,t5.Name ,t1.tran_sub_head";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // -- Vendor payment with -ve Transaction value (Capital account)

                strSql= " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " select t1.tran_date, 'AR' rec_type , tran_source rec_desc, t7.Name description, tran_sub_head sub_Desc " +
                                 " ,sum((ledger_AMT * -1)) ledger_amt ,@RevNo, @CreatedBy,@CreatedBy " +
                                " from vw_ledger_account t1 " +
                                " left outer join outward_remittance t6 on(t1.source_rk = t6.outward_rk) " +
                                " left outer join vendor_master t7 on t6.vendor_rk = t7.vendor_rk " +
                                " where tran_head = 'CASH' and t1.tran_Source = 'Vendor Payment' and t6.tran_amt < 0 " +
                                " and t1.tran_date = @DailyDate group by t1.tran_date,t1.tran_source ,t7.Name ,t1.tran_sub_head ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // actual expense entry paid to Vendors

                strSql= " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " select t1.tran_date, 'AP' rec_type , t1.tran_source rec_desc, t9.Name description, t1.tran_sub_head sub_Desc " +
                                 " ,sum((t1.ledger_AMT * -1)) ledger_amt ,@RevNo, @CreatedBy,@CreatedBy " +
                                " from vw_ledger_account t1 " +
                                " left outer join outward_remittance t8 on(t1.source_rk = t8.outward_rk) " +
                                " left outer join vendor_master t9 on t8.vendor_rk = t9.vendor_rk " +
                                " where tran_head = 'CASH' and t1.tran_Source = 'Vendor Payment' and t8.tran_amt > 0 " +
                                " and t1.tran_date = @DailyDate group by t1.tran_date,t1.tran_source ,t9.Name ,t1.tran_sub_head ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // Commision Paid to Driver

                strSql= " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " select t1.tran_date, 'AP' rec_type ,  tran_source rec_desc,'Driver Commmision' description , tran_sub_head sub_Desc" +
                                 " ,sum((ledger_AMT * -1)) ledger_amt ,@RevNo, @CreatedBy,@CreatedBy " +
                                 " from vw_ledger_account t1 " +
                                 " left outer join vw_invoice_header t10 on t1.source_rk = t10.invoice_rk" +
                                 " left OUTER join buyer_master t11 on t10.buyer_rk = t11.buyer_rk" +
                                 " where tran_head = 'CASH' and t1.tran_Source = 'Invoice' and tran_sub_head = 'Service Payment'" +
                                 " and t1.tran_date = @DailyDate group by t1.tran_date,t1.tran_source ,t1.tran_sub_head ";

                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql, Params);

                // Total Credit Amount Entry


                strSql= " select round(" + Global.gIsNull + "(sum(ledger_amt),0),0) from daily_details " +
                                  " where tran_date = @DailyDate and is_active = 1 and rec_type in ('OB','AR') and rev_no =@RevNo ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                dTotalCreditAmount = commonLib.fnCheckDecimal((objFactory.TransExecuteScalerQuery(strSql,Params).ToString()));



                // make an entry in db for Total Credit Amount
                strSql= " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " values " +
                                 " (@DailyDate,'TAR','Total Credit','Total Credit Amount','',@TotalCreditAmount,@RevNo,@CreatedBy,@CreatedBy) ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("TotalCreditAmount", dTotalCreditAmount.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql,Params);

                // Total Debit Amount


                strSql= " select round(" + Global.gIsNull + "(sum(ledger_amt),0),0) from daily_details " +
                                  " where tran_date = @DailyDate and is_active = 1 and rec_type in ('AP') and rev_no =@RevNo ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                dTotalDebitAmount = commonLib.fnCheckDecimal((objFactory.TransExecuteScalerQuery(strSql,Params).ToString()));



                // make an entry in db for Total Credit Amount
                strSql= " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " values " +
                                 " (@DailyDate,'TAP','Total Debit','Total Debit Amount','',@TotalDebitAmount,@RevNo,@CreatedBy,@CreatedBy) ";

                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("TotalDebitAmount", dTotalDebitAmount.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);
                objFactory.TransExecuteNonQuery(strSql,Params);


                // Total Closing Balance

                strSql= " select round(" + Global.gIsNull + "(sum(ledger_amt),0),0) from daily_details " +
                                  " where tran_date = @DailyDate and is_active = 1 and rev_no =@RevNo and rec_type in ('TAP','TAR')";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("RevNo", iRevNo.ToString());

                dClosingBal = commonLib.fnCheckDecimal((objFactory.TransExecuteScalerQuery(strSql,Params).ToString()));




                // make an entry in db for Opening Balance
                strSql = " insert into daily_details " +
                                 " (tran_date,rec_type,rec_desc,description,sub_desc,ledger_amt,rev_no,created_by,updated_by) " +
                                 " values " +
                                 " (@DailyDate,'CB','C/B','Closing Balance','',@ClosingBal,@RevNo,@CreatedBy,@CreatedBy) ";
                Params.Clear();
                Params.Add("DailyDate", DailyDate.ToString());
                Params.Add("ClosingBal", dClosingBal.ToString());
                Params.Add("RevNo", iRevNo.ToString());
                Params.Add("CreatedBy", CreatedBy);

                objFactory.TransExecuteNonQuery(strSql,Params);


                objFactory.TransCommit();
                objFactory.TransCloseConnection();
                strReturn = logicalOK + "Daily created sucessfully!!!";
                return strReturn;

            }
            catch (Exception e)
            {
                objFactory.TransRollback();
                objFactory.TransCloseConnection();
                return TechnicalError + "Process Name : " + ProcessName + " : " + e.Message;

            }


        }



    }
}
