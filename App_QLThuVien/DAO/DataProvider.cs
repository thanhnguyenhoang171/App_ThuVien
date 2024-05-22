using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }


        public DataProvider() { }

        // Connection String của mnkhue
       // string connectionString = @"Data Source=LAPTOP-3RR4R1FA\SQLEXPRESS; Initial Catalog = QuanLyThuVien; Integrated Security = True";

        // Connection String của hthanh
        private string connectionString = @"Data Source=LAS_Chanh\LASCHANH; Initial Catalog = QuanLyThuVien; Integrated Security = True";
        // Trả data theo yêu cầu query

        // Thêm kết nối tới cơ sở dữ liệu của bạn tại đây

        ///
        public DataTable ExecuteQuery (string query, object[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số nếu có
                    if (parameters != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParameter)
                        {
                            if (param.Contains("@")) {
                                command.Parameters.AddWithValue(param, parameters[i++]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataTable;
        }

        // Thực hiện thêm, xoá, sửa
        public int ExecuteNonQuery(string query, object[] parameters = null) {
            int result = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số nếu có
                    if (parameters != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParameter)
                        {
                            if (param.Contains('@')) {
                                command.Parameters.AddWithValue(param, parameters[i]);
                                i++;
                                }
                        }
                    }

                    result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error: " + ex.Message);
            }

            return result;
        }

        // thực hiện thêm, xoá, sửa
        public object ExecuteScalar(string query, object[] parameters = null) {
            object result = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số nếu có
                    if (parameters != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParameter)
                        {
                            if (param.Contains('@'))
                            {
                                command.Parameters.AddWithValue(param, parameters[i]);
                                i++;
                            }
                        }
                    }

                    result = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error: " + ex.Message);
            }

            return result;
        }

        // Hàm hỗ trợ thêm tham số vào SqlCommand
    }
}
