using DevExpress.XtraEditors;
using Newtonsoft.Json.Linq;
using ScandiHome.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

                string result = HttpHelper.webRequest("Customer/GetAll", null, "POST", "application/json");

                var jsonObject = JObject.Parse(result);
                DataTable dt = jsonObject["Data"].ToObject<DataTable>();
                gc_Data.DataSource = dt;

                waitForm.Close(dt);
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