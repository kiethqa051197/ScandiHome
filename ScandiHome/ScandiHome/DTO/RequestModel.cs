using System;

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
