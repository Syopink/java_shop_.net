using System.Drawing;
using System;
using System.Windows.Forms;
using Vietpro_Shop.Utils;

namespace Vietpro_Shop.Views
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private CheckBox termsCheckBox;
        private Button loginButton;
        private Label registerLabel;
        private Label forgotPasswordLabel;
        private Label termsLabel;
        private Label txtEmail;
        private Label txtPassword;

        private TextBox captchaTextBox;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.termsCheckBox = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(50, 50);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(50, 100);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.Location = new System.Drawing.Point(48, 191);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(77, 23);
            this.termsCheckBox.TabIndex = 2;
            this.termsCheckBox.Text = "Đồng ý với";
            this.termsCheckBox.CheckedChanged += new System.EventHandler(this.termsCheckBox_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(47, 221);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            // 
            // registerLabel
            // 
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Location = new System.Drawing.Point(180, 230);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(50, 18);
            this.registerLabel.TabIndex = 4;
            this.registerLabel.Text = "Đăng ký";
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.Location = new System.Drawing.Point(45, 258);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(151, 23);
            this.forgotPasswordLabel.TabIndex = 5;
            this.forgotPasswordLabel.Text = "Quên mật khẩu?";
            // 
            // termsLabel
            // 
            this.termsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsLabel.Location = new System.Drawing.Point(121, 195);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(75, 23);
            this.termsLabel.TabIndex = 6;
            this.termsLabel.Text = "Điều khoản";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(50, 120);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(100, 20);
            this.captchaTextBox.TabIndex = 10;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.termsCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.captchaTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
