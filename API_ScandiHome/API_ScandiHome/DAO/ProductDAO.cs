using API_ScandiHome.Ultils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace API_ScandiHome.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM dbo.SCH_view_GetAllProduct";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetProductBySKU(string pSKU)
        {
            string query = "SELECT * FROM dbo.SCH_view_GetProductDetail WHERE SKU=N'" + pSKU + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        private DataTable GetAllCombobox(string view)
        {
            string query = "SELECT * FROM dbo.SCH_view_GetAll" + view;

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetAllCategory()
        {
            return GetAllCombobox("Category");
        }

        public DataTable GetAllDesign()
        {
            return GetAllCombobox("Design");
        }

        public DataTable GetAllModel()
        {
            return GetAllCombobox("Model");
        }

        public DataTable GetAllSeries()
        {
            return GetAllCombobox("Series");
        }

        public DataTable GetAllProductSKU()
        {
            string query = "SELECT ProductCode as DataCode, ProductCode as DataName FROM dbo.SKUProduct";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}