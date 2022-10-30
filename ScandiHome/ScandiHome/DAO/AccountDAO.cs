using ScandiHome.Ultils;

namespace ScandiHome.DAO
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
            var data = DataProvider.Instance.ExecuteQuery("EXEC SCH_proc_Login @username , @password ", new object[] { userName, password });
            return new Account(data.Rows[0]);
        }
    }
}