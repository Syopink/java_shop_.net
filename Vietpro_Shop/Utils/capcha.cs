using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vietpro_Shop.Utils;

namespace Vietpro_Shop.Utils
{
    public class Capcha : Panel
    {
        private TextBox captchaField;
        private Button refreshButton;
        private Random random;

        public Capcha()
        {
            random = new Random();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.captchaField = new TextBox();
            this.refreshButton = new Button();

            // Set up captcha field
            this.captchaField.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.captchaField.TextAlign = HorizontalAlignment.Center;
            this.captchaField.ReadOnly = true;
            this.captchaField.Text = GenerateCaptcha();  // Chỉ gọi từ trong lớp Capcha
            this.captchaField.Dock = DockStyle.Top;

            // Set up refresh button
            this.refreshButton.Text = "Tạo mới";
            this.refreshButton.Font = new Font("Segoe UI", 12);
            this.refreshButton.Dock = DockStyle.Bottom;
            this.refreshButton.Padding = new Padding(0, 0, 10, 0); // Thêm khoảng cách bên phải nếu muốn

            // Add controls to the panel
            this.Controls.Add(this.captchaField);
            this.Controls.Add(this.refreshButton);
        }

        // Generate a random CAPTCHA code
        private string GenerateCaptcha()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder captcha = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                captcha.Append(chars[random.Next(chars.Length)]);
            }
            return captcha.ToString();
        }

        // Return the current CAPTCHA value
        public string GetCaptchaField()
        {
            return captchaField.Text;
        }

        // Reset the CAPTCHA field with a new value
        public void ResetCaptcha()
        {
            captchaField.Text = GenerateCaptcha();  // Gọi lại từ trong lớp Capcha
        }
    }

}
