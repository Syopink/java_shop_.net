using System;
using System.Windows.Forms;
using System.IO;
using Vietpro_Shop.Components.customer;
using Vietpro_Shop.Utils;
using Vietpro_Shop.Models;
using System.Configuration;

namespace Vietpro_Shop.Views
{
    public partial class Login : Form
    {
        private UserDTO userDTO;
        private Customers customers;
        private Capcha capcha;

        public Login()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["VietProConnection"].ConnectionString;
            customers = new Customers(connectionString);

            capcha = new Capcha();
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle any cleanup if needed
            MessageBox.Show("Login button clicked!");

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Logic xử lý khi bấm nút Login
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = customers.Login(email, password);
            if (role != "none")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Điều hướng tới form khác dựa trên role
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            // Logic for opening register form
            MessageBox.Show("Forgot password label clicked!");

        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            // Logic for opening forgot password form
        }

        private void TermsLabel_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Onedrive\Documents\NetBeansProjects\VietPro3\java_shop\src\main\resources\DKSD.txt";

            if (File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Unable to open the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
