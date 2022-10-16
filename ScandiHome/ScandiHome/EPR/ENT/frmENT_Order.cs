using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScandiHome.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ScandiHome.EPR.ENT
{
    public partial class frmENT_Order : DevExpress.XtraEditors.XtraForm
    {
        bool mFormList = true;

        public frmENT_Order()
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

        private void frmENT_Order_KeyDown(object sender, KeyEventArgs e)
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

                RefreshDataDetail(gv_Data.GetFocusedRowCellValue("OrderCode").ToString());
            }
        }

        private void RefreshData()
        {
            try
            {
                WaitFormFunc waitForm = new WaitFormFunc();
                waitForm.Show();

                Thread.Sleep(500);

                string result = HttpHelper.webRequest("Order/GetAll", null, "POST", "application/json");

                var jsonObject = JObject.Parse(result);
                DataTable dt = jsonObject["Data"].ToObject<DataTable>();
                gc_Data.DataSource = dt;

                waitForm.Close(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshDataDetail(string pOrderId)
        {
            try
            {
                RequestModel model = new RequestModel(pOrderId, "");
                var json = JsonConvert.SerializeObject(model);

                string result = HttpHelper.webRequest("Order/GetOrderDetail", json, "POST", "application/json");

                var jsonObject = JObject.Parse(result);
                DataTable dt = jsonObject["Data"].ToObject<DataTable>();
                gc_DataDetail.DataSource = dt;
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