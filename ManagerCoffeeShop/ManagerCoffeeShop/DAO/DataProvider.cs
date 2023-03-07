using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCoffeeShop.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionStr = "Data Source=DESKTOP-6552D8E\\NHANNHAN;Initial Catalog=ManageCoffeeShop;User ID=sa;Password=12345";
        
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionStr)) {
                conn.Open();

                SqlCommand comand = new SqlCommand(query, conn);

                if(parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara) {
                        if (item.Contains("@")) {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comand);

                adapter.Fill(data);

                conn.Close();
            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionStr)) {
                conn.Open();

                SqlCommand comand = new SqlCommand(query, conn);

                if (parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara) {
                        if (item.Contains("@")) {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = comand.ExecuteNonQuery();
                conn.Close();
            }

            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectionStr)) {
                conn.Open();

                SqlCommand comand = new SqlCommand(query, conn);

                if (parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara) {
                        if (item.Contains("@")) {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = comand.ExecuteScalar();
                conn.Close();
            }

            return data;
        }
    }
}
