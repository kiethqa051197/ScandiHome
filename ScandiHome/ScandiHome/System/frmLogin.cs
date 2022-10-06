using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScandiHome
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RequestModel model = new RequestModel(txtUserName.Text, txtPass.Text);

            var json = JsonConvert.SerializeObject(model);

            string result = HttpHelper.webRequest("https://localhost:44368/api/Account/login", json, "POST", "application/json");

            var country = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel<Account>>(result);

            if (country.Succeeded)
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(country.Errors);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}