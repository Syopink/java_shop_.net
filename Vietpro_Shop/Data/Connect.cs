using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Namespace để làm việc với SQL Server
using System.Windows.Forms; // Namespace để hiển thị thông báo
using System.Configuration; // Namespace để làm việc với App.config

namespace Database
{
    public class Connect
    {
        private SqlConnection conn = null;

        public SqlConnection ConnectSQL()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                return conn;
            }

            try
            {
                var connectionStringSettings = ConfigurationManager.ConnectionStrings["VietProConnection"];
                if (connectionStringSettings == null)
                {
                    MessageBox.Show("Chuỗi kết nối không tồn tại trong App.config.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                string connectionString = connectionStringSettings.ConnectionString;

                conn = new SqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("Kết nối CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kết nối CSDL thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }

    }
}
