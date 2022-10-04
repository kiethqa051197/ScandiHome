using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace API_ScandiHome.DTO
{
    public class Account
    {
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["FirstName"].ToString() + " " + row["LastName"].ToString();
        }

        private string userName;
        private string displayName;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}