using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }


        public DataProvider() { }

        string connectionString = @"Data Source=LAS_Chanh\LASCHANH; Initial Catalog = QuanLyThuVien; Integrated Security = True";

        // Trả data theo yêu cầu query

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
                        AddParameters(command, parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
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
                        AddParameters(command, parameters);
                    }

                    result = command.ExecuteNonQuery();
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
                        AddParameters(command, parameters);
                    }

                    result = command.ExecuteScalar();
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
        private void AddParameters(SqlCommand command, object[] parameters)
        {
            string[] parameterList = command.CommandText.Split(' ');
            int i = 0;
            foreach (string item in parameterList)
            {
                if (item.Contains('@'))
                {
                    command.Parameters.AddWithValue(item, parameters[i]);
                    i++;
                }
            }
        }
    }
}
