using API_ScandiHome.Ultils;
using System.Data;

namespace API_ScandiHome.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            private set { instance = value; }
        }

        private OrderDAO() { }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM dbo.SHC_view_GetAllOrder";

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

        public DataTable GetOrderDetail(string pOrder)
        {
            string query = "SELECT * FROM dbo.SHC_view_GetOrderDetail WHERE OrderCode=N'" + pOrder + "'";

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