using API_ScandiHome.DTO;
using API_ScandiHome.Ultils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace API_ScandiHome.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public DataTable Login(string userName, string password)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC SCH_proc_Login @username , @password ", new object[] { userName, password });
        }
    }
}