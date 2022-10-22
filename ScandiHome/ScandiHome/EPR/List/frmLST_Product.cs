using ScandiHome.DAO;
using ScandiHome.Helper;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace ScandiHome.EPR.List
{
    public partial class frmLST_Product : DevExpress.XtraEditors.XtraForm
    {
        bool mFormList = true;

        public frmLST_Product()
        {
            InitializeComponent();

            tpl_Main.ColumnStyles[1].SizeType = SizeType.Absolute;
            tpl_Main.ColumnStyles[1].Width = 0;

            RefreshData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void frmLST_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && !mFormList)
            {
                tpl_Main.ColumnStyles[1].SizeType = SizeType.Percent;
                tpl_Main.ColumnStyles[1].Width = 0;

                tpl_Main.ColumnStyles[0].SizeType = SizeType.Percent;
                tpl_Main.ColumnStyles[0].Width = 100;

                mFormList = true;
            }
            else if (e.KeyCode == Keys.F4 && mFormList)
            {
                tpl_Main.ColumnStyles[0].SizeType = SizeType.Percent;
                tpl_Main.ColumnStyles[0].Width = 0;

                tpl_Main.ColumnStyles[1].SizeType = SizeType.Percent;
                tpl_Main.ColumnStyles[1].Width = 100;

                mFormList = false;

                RefreshDataDetail(gv_Data.GetFocusedRowCellValue("SKU").ToString());
            }
            else if (e.KeyCode == Keys.F5)
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

                var mResult = ProductDAO.Instance.GetAll();

                gc_Data.DataSource = mResult;
               
                waitForm.Close(mResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshDataDetail(string pSKU)
        {
            try
            {
                var mResult = ProductDAO.Instance.GetQuotaProductWithPrice(pSKU);
                gc_Material.DataSource = mResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmLST_Product_Input mform = new frmLST_Product_Input(gv_Data.GetFocusedRowCellValue("SKU").ToString());
            mform.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}