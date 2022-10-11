using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScandiHome.EPR.List
{
    public partial class frmLST_Product : DevExpress.XtraEditors.XtraForm
    {
        public frmLST_Product()
        {
            InitializeComponent();

            string result = HttpHelper.webRequest("https://localhost:44368/api/Product/GetAll", null, "POST", "application/json");

            var jsonObject = JObject.Parse(result);
            DataTable dt = jsonObject["Data"].ToObject<DataTable>();

            grdProduct.DataSource = dt;
        }
    }
}