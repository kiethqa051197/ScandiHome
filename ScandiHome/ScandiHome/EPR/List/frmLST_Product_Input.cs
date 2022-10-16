using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScandiHome.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ScandiHome.EPR.List
{
    public partial class frmLST_Product_Input : DevExpress.XtraEditors.XtraForm
    {
        public frmLST_Product_Input()
        {
            InitializeComponent();
        }
        
        public frmLST_Product_Input(string pSKU)
        {
            InitializeComponent();

            LoadCombo_Category();
            LoadCombo_GetAllDesign();
            LoadCombo_GetAllModel();
            LoadCombo_GetAllSeries();
            LoadCombo_GetAllProductSKU();

            try
            {
                RequestModel model = new RequestModel(pSKU, "");
                var json = JsonConvert.SerializeObject(model);

                string result = HttpHelper.webRequest("Product/GetProductBySKU", json, "POST", "application/json");

                var mResult = JsonConvert.DeserializeObject<ResponseModel<List<GetProductDetail>>>(result);

                if (mResult.Succeeded)
                {
                    GetProductDetail mData = mResult.Data[0];

                    cb_Category.EditValue = mData.CategoryCode;
                    cb_Designer.EditValue = mData.Designer;
                    cb_Model.EditValue = mData.GroupSKUCode;
                    cb_Product.EditValue = mData.ProductCode;
                    cb_Series.EditValue = mData.SeriesCode;

                    txtProductName.EditValue = mData.ProductName;
                    txtDescription.EditValue = mData.NewProductNote;

                    txtCreateBy.EditValue = mData.CreatedBy;
                    txtCreateDate.EditValue = mData.Created.Replace("T", " ");

                    txtModifyBy.EditValue = mData.LastModifiedBy;
                    txtModifyDate.EditValue = (mData.LastModified == null ? "" : mData.LastModified.Replace("T", " ")) ;


                    DataTable dt_Material = new DataTable();

                    DataColumn colSTT_Material = new DataColumn("STT",typeof(System.Int32));
                    DataColumn colDataCode_Material = new DataColumn("DataCode", typeof(System.String));
                    DataColumn colDataName_Material = new DataColumn("DataName", typeof(System.String));
                    DataColumn colQuantity_Material = new DataColumn("Quantity", typeof(System.Double));
                    DataColumn colAmount_Material = new DataColumn("Amount", typeof(System.Double));
                    DataColumn colTotalAmount_Material = new DataColumn("TotalAmount", typeof(System.Double));

                    dt_Material.Columns.AddRange(new DataColumn[] { colSTT_Material, colDataCode_Material, colDataName_Material, colQuantity_Material, colAmount_Material, colTotalAmount_Material });

                    int countMaterial = 0;
                    foreach (var m in mResult.Data.Where(p => p.TypeCode == 1))
                    {
                        countMaterial += 1;
                        dt_Material.Rows.Add(countMaterial, m.DataCode, m.DataName, m.Quantity, m.Amount, m.TotalAmount);
                    }

                    gc_Material.DataSource = dt_Material;

                    DataTable dt_Color = new DataTable();

                    DataColumn colSTT_Color = new DataColumn("STT", typeof(System.Int32));
                    DataColumn colDataCode_Color = new DataColumn("DataCode", typeof(System.String));
                    DataColumn colDataName_Color = new DataColumn("DataName", typeof(System.String));

                    dt_Color.Columns.AddRange(new DataColumn[] { colSTT_Color, colDataCode_Color, colDataName_Color });

                    int countColor = 0;
                    foreach (var m in mResult.Data.Where(p => p.TypeCode == 2))
                    {
                        countColor += 1;
                        dt_Color.Rows.Add(countColor, m.DataCode, m.DataName);
                    }

                    gc_Color.DataSource = dt_Color;
                }
                else
                {
                    MessageBox.Show(mResult.Errors);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCombo(string pFunction, DevExpress.XtraEditors.LookUpEdit cbb)
        {
            string result = HttpHelper.webRequest("Product/" + pFunction, null, "POST", "application/json");

            var jsonObject = JObject.Parse(result);
            DataTable dt = jsonObject["Data"].ToObject<DataTable>();

            cbb.Properties.DataSource = dt;
        }

        private void LoadCombo_Category() 
        {
            LoadCombo("GetAllCategory", cb_Category);
        }

        private void LoadCombo_GetAllDesign()
        {
            LoadCombo("GetAllDesign", cb_Designer);
        }

        private void LoadCombo_GetAllModel()
        {
            LoadCombo("GetAllModel", cb_Model);
        }

        private void LoadCombo_GetAllSeries()
        {
            LoadCombo("GetAllSeries", cb_Series);
        }

        private void LoadCombo_GetAllProductSKU()
        {
            LoadCombo("GetAllProductSKU", cb_Product);
        }
    }
}