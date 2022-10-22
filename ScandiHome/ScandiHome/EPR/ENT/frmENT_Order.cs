using ScandiHome.DAO;
using ScandiHome.Helper;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ScandiHome.EPR.ENT
{
    public partial class frmENT_Order : DevExpress.XtraEditors.XtraForm
    {
        public frmENT_Order()
        {
            InitializeComponent();
            
            RefreshData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void frmENT_Order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshData();
            }
        }

        private void RefreshData()
        {
            try
            {
                WaitFormFunc waitForm = new WaitFormFunc();
                waitForm.Show();

                Thread.Sleep(500);

                var result = OrderDAO.Instance.GetAll();
                gc_Data.DataSource = result;

                waitForm.Close(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}