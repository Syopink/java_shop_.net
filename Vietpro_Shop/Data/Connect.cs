using System;
using System.Windows.Forms; // Namespace để hiển thị thông báo
using MySql.Data.MySqlClient; // Namespace để làm việc với MySQL
using System.Configuration; // Namespace để làm việc với App.config

namespace Database
{
    public class Connect
    {
        private MySqlConnection conn = null;

        public MySqlConnection ConnectMySQL()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open) // Kiểm tra nếu đã có kết nối
            {
                return conn;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["VietProConnection"].ConnectionString;

                conn = new MySqlConnection(connectionString);
                conn.Open(); // Mở kết nối
                MessageBox.Show("Kết nối CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Kết nối CSDL thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }
    }
}
