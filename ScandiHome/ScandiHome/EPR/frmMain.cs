using ScandiHome.EPR.ENT;
using ScandiHome.EPR.List;
using ScandiHome.EPR.Setting;
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

        private void mnu_Customer_Click(object sender, EventArgs e)
        {
            frmLST_Customer frm = new frmLST_Customer();
            frm.ShowDialog();
        }

        private void nu_quota_Click(object sender, EventArgs e)
        {
            frmST_Quota frm = new frmST_Quota();
            frm.ShowDialog();
        }
    }
}