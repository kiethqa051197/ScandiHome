using ScandiHome.DAO;
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
            var mResult = AccountDAO.Instance.Login(txtUserName.Text, txtPass.Text);

            if (mResult.Success)
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
                MessageBox.Show(mResult.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}