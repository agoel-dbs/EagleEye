using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye.Lib
{
    class RavanaaData
    {
        public int SeqNo { get; set; }
        public string DataHeader { get; set; }
        public string DataValue { get; set; }

        public RavanaaData(int pSeqNo, string pDataHeader, string pDataValue)
        {
            this.SeqNo = pSeqNo;
            this.DataHeader = pDataHeader;
            this.DataValue = pDataValue;
        }
    }
}
