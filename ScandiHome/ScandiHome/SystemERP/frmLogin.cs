using Newtonsoft.Json;
using System;
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

            string result = HttpHelper.webRequest("Account/login", json, "POST", "application/json");

            var country = JsonConvert.DeserializeObject<ResponseModel<Account>>(result);

            if (country.Succeeded)
            {
                try
                {
                    this.Hide();
                    frmMain frmMain = new frmMain();
                    frmMain.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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