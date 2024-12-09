using Resources;
using System;
using System.Drawing;
using System.Windows.Forms;
using Vietpro_Shop.Controllers;
using Vietpro_Shop.Views;
using Resources;

namespace Vietpro_Shop
{
    public partial class HomePage : Form
    {
        private int posX = 0, posY = 0; // Variables for mouse drag

        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1210, 590);

            // Mouse event handlers for dragging the form
            this.MouseDown += (sender, e) =>
            {
                posX = e.X;
                posY = e.Y;
            };

            this.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Location = new Point(e.X + this.Left - posX, e.Y + this.Top - posY);
                }
            };

            setUpPanels();
        }


        public void setUpPanels()
        {
            // Create an instance of CardLayout with the mainPanel
            CardLayout cardLayout = new CardLayout(mainPanel);

            // Add components to the main panel with CardLayout
            mainPanel.Controls.Add(new ManagerProducts(), "Sản phẩm");
            mainPanel.Controls.Add(new ManagerUser(), "Thành viên");
            mainPanel.Controls.Add(new ManagerCategory(), "Danh mục");
            mainPanel.Controls.Add(new ManagerOrders(), "Đơn hàng");
            mainPanel.Controls.Add(new ManagerCustomer(), "Khách hàng");

            // Show the initial panel


            // Set up navigation buttons in the navbar
            navbar1.SetRouter1(mainPanel, "Sản phẩm");
            navbar1.SetRouter2(mainPanel, "Thành viên");
            navbar1.SetRouter3(mainPanel, "Danh mục");
            navbar1.SetRouter4(mainPanel, "Đơn hàng");
            navbar1.SetRouter5(mainPanel, "Khách hàng");
        }
    }

    public class CardLayout
    {
        private Panel mainPanel;

        public CardLayout(Panel panel)
        {
            mainPanel = panel;
        }

        public void Show(string cardName)
        {
            foreach (Control control in mainPanel.Controls)
            {
                if (control is UserControl userControl && userControl.Name == cardName)
                {
                    control.BringToFront();
                    break;
                }
            }
        }
    }
}
