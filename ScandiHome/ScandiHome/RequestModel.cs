using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScandiHome
{
    class RequestModel
    {
        public string DataCode = string.Empty;
        public string DataValue = string.Empty;

        public RequestModel() { }

        public RequestModel(string pDataCode, String pDataValue)
        {
            this.DataCode = pDataCode;
            this.DataValue = pDataValue;
        }
    }
}
