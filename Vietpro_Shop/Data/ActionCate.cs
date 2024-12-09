using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class ActionCate
    {
        private SqlConnection connection;

        public ActionCate()
        {
            Connect conn = new Connect(); // Khởi tạo đối tượng Connect
            connection = conn.ConnectSQL(); // Kết nối tới cơ sở dữ liệu
        }

        public List<object[]> GetCate()
        {
            string query = "SELECT * FROM categories";
            List<object[]> resultList = new List<object[]>();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idCate = reader.GetInt32(reader.GetOrdinal("idCate"));
                        string name = reader.GetString(reader.GetOrdinal("title"));
                        string createdAt = reader.GetString(reader.GetOrdinal("createdAt"));
                        string updatedAt = reader.GetString(reader.GetOrdinal("updatedAt"));

                        object[] row = new object[4];
                        row[0] = idCate;
                        row[1] = name;
                        row[2] = createdAt;
                        row[3] = updatedAt;

                        resultList.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return resultList;
        }

        public string UpdateCate(int id, string title)
        {
            string query = "UPDATE categories SET title = @title WHERE idCate = @idCate";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@idCate", id);

                    int rowsUpdated = command.ExecuteNonQuery();
                    return rowsUpdated > 0 ? "Cập nhật thành công" : "Cập nhật thất bại";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "An error occurred: " + e.Message;
            }
        }

        public string AddCate(string title)
        {
            string query = "INSERT INTO categories (title, descriptions) VALUES (@title, @descriptions)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@descriptions", "Dien thoai");

                    int rowsInserted = command.ExecuteNonQuery();
                    return rowsInserted > 0 ? "Thêm mới thành công" : "Thêm mới thất bại";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "An error occurred: " + e.Message;
            }
        }

        public string DeleteCate(int id)
        {
            string query = "DELETE FROM categories WHERE idCate = @idCate";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCate", id);

                    int rowsDeleted = command.ExecuteNonQuery();
                    return rowsDeleted > 0 ? "Xóa thành công" : "Xóa thất bại";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "An error occurred: " + e.Message;
            }
        }
    }
}
