using API_ScandiHome.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_ScandiHome.Models
{
    public class ResponseModel
    {
        public int DataStatus = 0;
        public string DataCode = string.Empty;
        public Account DataValue = null;
        public string DataErrorDescription = string.Empty;

        public ResponseModel(int pDataStatus, string pDataCode, Account pDataValue, string pDataErrorDescription)
        {
            this.DataStatus = pDataStatus;
            this.DataCode = pDataCode;
            this.DataValue = pDataValue;
            this.DataErrorDescription = pDataErrorDescription;
        }
    }
}