using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScandiHome
{
    class Account
    {
        private string userName;
        private string displayName;

        public Account(string pUserName, string pDisplayName)
        {
            this.UserName = pUserName;
            this.DisplayName = pDisplayName;
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
