using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_ScandiHome.Models
{
    public class RequestModel
    {
        public string DataCode = string.Empty;
        public string DataValue = string.Empty;

        public RequestModel(string pDataCode, String pDataValue)
        {
            this.DataCode = pDataCode;
            this.DataValue = pDataValue;
        }
    }
}