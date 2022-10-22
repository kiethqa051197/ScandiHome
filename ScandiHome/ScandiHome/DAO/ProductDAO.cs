using ScandiHome.Ultils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ScandiHome.DAO
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
            string query = "SELECT * FROM dbo.SCH_view_GetAllProduct D ORDER BY D.SKU";

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

        public DataTable GetDetailProduct(string pSKU)
        {
            string query = "SELECT * FROM dbo.SCH_view_GetAllProduct D WHERE D.SKU = N'" + pSKU + "' ORDER BY D.SKU";

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

        public DataTable GetQuotaProductWithPrice(string pSKU)
        {
            string query = "SELECT " +
                                "ROW_NUMBER() OVER (ORDER BY SKU) AS ID " +
                                ", * " +
                                ", (SELECT PQ.ProductName FROM ProductQuota PQ WHERE D.ProductMaterialCode = PQ.ProductCode) AS ProductMaterialName " +
                                ", (SELECT DD.ProductName FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS ProductName " +
                                ", (SELECT DD.CategoryCode FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS CategoryCode " +
                                ", (SELECT DD.ModelSKUCode FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS ModelSKUCode " +
                                ", (SELECT DD.InhouseSeries FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS SeriesName " +
                                ", (SELECT DD.NewProductNote FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS NewProductNote " +
                           "FROM dbo.SCH_view_QuotaProductWithPrice D " +
                           "WHERE " +
                                "D.SKU = N'" + pSKU + "' " +
                           "ORDER BY D.SKU, D.BP DESC, D.TP DESC";

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

        public DataTable GetColorProduct(string pSKU)
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY SKU) AS ID , * FROM dbo.SCH_view_GetProductWithColor D WHERE D.SKU = N'" + pSKU + "'";

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

        public DataTable GetAllModel()
        {
            return GetAllCombobox("Model");
        }
    }
}