using System.Data;

namespace ScandiHome
{
    public class Account
    {
        private string userName;
        private string displayName;
        private bool success;
        private string message;

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.Success = bool.Parse(row["success"].ToString());
            this.Message = row["message"].ToString();
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public bool Success { get => success; set => success = value; }
        public string Message { get => message; set => message = value; }
    }
}
