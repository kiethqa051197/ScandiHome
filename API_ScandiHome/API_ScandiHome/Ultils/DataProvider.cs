using System;
using System.Linq;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace API_ScandiHome.Ultils
{
    public class DataProvider
    {
        //static là biến chỉ được gọi 1 lần thông qua tên hàm và được khởi tạo 1 lần duy nhất
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string ConnectionSTR()
        {
            var path = System.Web.Hosting.HostingEnvironment.MapPath("/");

            ReadWriteINIfile readWriteINIfile = new ReadWriteINIfile(Path.Combine(path, "AppConfig.INI"));

            var mInstance = readWriteINIfile.ReadINI("Connection", "Instance");
            var mDBConnection = readWriteINIfile.ReadINI("Connection", "DBConnection");
            var mUser = readWriteINIfile.ReadINI("Connection", "User");
            var mPass = readWriteINIfile.ReadINI("Connection", "Pass");

            return String.Format("Data Source={0}; Initial Catalog={1};User Id={2};Password={3};Trusted_Connection=False;MultipleActiveResultSets=true;", mInstance, mDBConnection, mUser, mPass);
        }

        public DataTable ExecuteQuery(string query, Object[] parameter = null)
        {
            DataTable data = new DataTable();

            //using là cho dù có vấn đề gì đi nữa kết thúc khối lệnh thì những dữ liệu ở đây sẽ đc giải phóng
            using (SqlConnection connection = new SqlConnection(ConnectionSTR()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 0;

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNoneQuery(string query, Object[] parameter = null)
        {
            int data = 0;

            //using là cho dù có vấn đề gì đi nữa kết thúc khối lệnh thì những dữ liệu ở đây sẽ đc giải phóng
            using (SqlConnection connection = new SqlConnection(ConnectionSTR()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 0;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, Object[] parameter = null)
        {
            object data = 0;

            //using là cho dù có vấn đề gì đi nữa kết thúc khối lệnh thì những dữ liệu ở đây sẽ đc giải phóng
            using (SqlConnection connection = new SqlConnection(ConnectionSTR()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 0;

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}