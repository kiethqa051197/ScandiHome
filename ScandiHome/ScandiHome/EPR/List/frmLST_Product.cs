using Newtonsoft.Json.Linq;
using ScandiHome.Helper;
using System;
using System.Data;
using System.Threading;

namespace ScandiHome.EPR.List
{
    public partial class frmLST_Product : DevExpress.XtraEditors.XtraForm
    {
        public frmLST_Product()
        {
            InitializeComponent();

            
            RefreshData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                WaitFormFunc waitForm = new WaitFormFunc();
                waitForm.Show();

                Thread.Sleep(500);

                string result = HttpHelper.webRequest("Product/GetAll", null, "POST", "application/json");

                var jsonObject = JObject.Parse(result);
                DataTable dt = jsonObject["Data"].ToObject<DataTable>();
                gc_Data.DataSource = dt;
               
                waitForm.Close(dt);
            }
            catch { }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmLST_Product_Input mform = new frmLST_Product_Input(gv_Data.GetFocusedRowCellValue("SKU").ToString());
            mform.ShowDialog();
        }

        private void frmLST_Product_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F5)
            {
                RefreshData();
            }
        }
    }
}