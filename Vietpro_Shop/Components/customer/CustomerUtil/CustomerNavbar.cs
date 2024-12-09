using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vietpro_Shop.Controllers;

namespace Vietpro_Shop.Components.customer.CustomerUtil
{
    public partial class CustomerNavbar : UserControl
    {
        public event Action<string> SwitchControl;
        public CustomerNavbar()
        {
            InitializeComponent();
            button1.Click += button1_Click;  // Button đã có sẵn trong Design
            button2.Click += button2_Click;  // Button đã có sẵn trong Design
            button3.Click += button3_Click;  // Button đ    
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            SwitchControl?.Invoke("CustomerCartPage");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchControl?.Invoke("CustomerHomePage");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwitchControl?.Invoke("CustomerOrderPage");
        }

    
    }
}
