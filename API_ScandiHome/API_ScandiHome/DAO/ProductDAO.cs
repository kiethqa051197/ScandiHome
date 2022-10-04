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
            string query = "SELECT * FROM dbo.SCH_view_GetAllProduct WHERE SKU=N'" + pSKU + "'";

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