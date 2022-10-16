using ScandiHome.EPR.ENT;
using ScandiHome.EPR.List;
using System;

namespace ScandiHome
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnu_product_Click(object sender, EventArgs e)
        {
            frmLST_Product frm = new frmLST_Product();
            frm.ShowDialog();
        }

        private void mnu_order_Click(object sender, EventArgs e)
        {
            frmENT_Order frm = new frmENT_Order();
            frm.ShowDialog();
        }
    }
}