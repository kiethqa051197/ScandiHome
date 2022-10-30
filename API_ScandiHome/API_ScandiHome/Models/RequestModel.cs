using System;

namespace API_ScandiHome.Models
{
    public class RequestModel
    {
        public string DataCode = string.Empty;
        public string DataValue = string.Empty;

        public RequestModel(string pDataCode, string pDataValue)
        {
            this.DataCode = pDataCode;
            this.DataValue = pDataValue;
        }
    }
}