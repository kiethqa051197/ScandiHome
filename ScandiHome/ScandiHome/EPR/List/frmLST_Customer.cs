using ScandiHome.DAO;
using ScandiHome.Helper;
using System.Threading;
using System.Windows.Forms;

namespace ScandiHome.EPR.List
{
    public partial class frmLST_Customer : DevExpress.XtraEditors.XtraForm
    {
        public frmLST_Customer()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                WaitFormFunc waitForm = new WaitFormFunc();
                waitForm.Show();

                Thread.Sleep(500);

                var result = CustomerDAO.Instance.GetAll();
                gc_Data.DataSource = result;

                waitForm.Close(result);
            }
            catch { }
        }

        private void frmLST_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F5)
            {
                RefreshData();
            }
        }
    }
}