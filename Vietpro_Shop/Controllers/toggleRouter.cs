using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Vietpro_Shop.Controllers
{
    public partial class toggleRouter : UserControl
    {
        public toggleRouter()
        {
            InitializeComponent();
        }

        // Phương thức trả về Label
        public Label GetLabel()
        {
            return label1;
        }

        // Phương thức trả về PictureBox
        public PictureBox GetPictureBox()
        {
            return pictureBox1;
        }

        // Phương thức thiết lập văn bản, hình ảnh và sự kiện click cho label
        public void Set(string text, Panel mainPanel, string imgPath)
        {
            label1.Text = " " + text;

            // Đường dẫn tuyệt đối từ thư mục gốc của dự án
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
            string imagePath = Path.Combine(basePath, imgPath);

            // Kiểm tra nếu ảnh tồn tại
            if (File.Exists(imagePath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show($"Image file not found: {imagePath}");
            }

            // Thêm sự kiện click cho label để hiển thị trang tương ứng
            label1.Click += (sender, e) =>
            {
                if (mainPanel != null)
                {
                    foreach (Control ctrl in mainPanel.Controls)
                    {
                        if (ctrl.Name == text) // Tìm UserControl theo tên
                        {
                            ctrl.BringToFront(); // Hiển thị UserControl đó
                            break;
                        }
                    }
                }
            };

            // Thêm sự kiện di chuột vào label để hiển thị màu trắng mờ
            label1.MouseEnter += (sender, e) =>
            {
                label1.BackColor = Color.FromArgb(50, Color.White); // Màu trắng mờ
            };

            // Thêm sự kiện khi rời chuột khỏi label để khôi phục màu nền
            label1.MouseLeave += (sender, e) =>
            {
                label1.BackColor = Color.Transparent; // Khôi phục màu nền ban đầu
            };
        }
    }
}
