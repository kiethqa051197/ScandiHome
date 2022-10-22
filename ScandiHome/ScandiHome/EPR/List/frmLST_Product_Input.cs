using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScandiHome.DAO;
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
            LoadCombo_GetAllModel();

            try
            {
                var result = ProductDAO.Instance.GetQuotaProductWithPrice(pSKU);

                if (result != null)
                {
                    cb_Category.EditValue = result.Rows[0]["CategoryCode"].ToString();
                    cb_Model.EditValue = result.Rows[0]["ModelSKUCode"].ToString();
                    txtSeries.EditValue = result.Rows[0]["SeriesName"].ToString();

                    txtProductName.EditValue = result.Rows[0]["ProductName"].ToString();
                    txtDescription.EditValue = result.Rows[0]["NewProductNote"].ToString();

                    DataTable dt_Material = result;
                    gc_Material.DataSource = dt_Material;

                    DataTable dt_Color = ProductDAO.Instance.GetColorProduct(pSKU);
                    gc_Color.DataSource = dt_Color;
                }
                else
                {
                    //MessageBox.Show(mResult.Errors);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCombo_Category() 
        {
            var mResult = ProductDAO.Instance.GetAllCategory();
            cb_Category.Properties.DataSource = mResult;
        }

        private void LoadCombo_GetAllModel()
        {
            var mResult = ProductDAO.Instance.GetAllModel();
            cb_Model.Properties.DataSource = mResult;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtProductName_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}