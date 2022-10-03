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

        public Account Login(string userName, string password)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";

            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}
            ////var list = hasData.ToString();
            ////list.Reverse();

            string query = string.Format("SELECT * FROM dbo.[User] WHERE UserName=N'{0}' AND PasswordHash=N'{1}'", userName, password);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return new Account(userName, password, 1);
            }
            else
            {
                return null;
            }
        }
    }
}