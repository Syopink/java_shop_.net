using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vietpro_Shop.Components.customer.CustomerPage;
using Vietpro_Shop.Components.customer.CustomerUtil;
using Vietpro_Shop.Controllers;

namespace Vietpro_Shop.Components.customer
{
    public partial class CustomerLayout : Form
    {
        public CustomerLayout()
        {
            InitializeComponent();
            CustomerNavbar navbarForm = new CustomerNavbar();
            navbarForm.Dock = DockStyle.Top;
            navbarForm.SwitchControl += OnSwitchControl;  // Đăng ký sự kiện
            this.Controls.Add(navbarForm);
        }
        private void OnSwitchControl(string controlName)
        {
            UserControl newControl = null;

            // Xác định UserControl nào cần hiển thị dựa trên tên được truyền từ NavbarForm
            switch (controlName)
            {
                case "UserControl1":
                    newControl = new CustomerHomePage();
                    break;
                case "UserControl2":
                    newControl = new CustomerCartPage();
                    break;
                case "UserControl3":
                    newControl = new CustomerOrderPage();
                    break;
            }

            // Nếu có UserControl hợp lệ, chuyển UserControl vào panel
            if (newControl != null)
            {
                SwitchUserControl(newControl);
            }
        }

        private void SwitchUserControl(UserControl newControl)
        {
            // Xóa các control cũ trong Panel
            panel1.Controls.Clear();

            // Thêm UserControl mới vào Panel
            newControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(newControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
