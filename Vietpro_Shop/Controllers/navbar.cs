using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vietpro_Shop.Controllers
{
    public partial class navbar : UserControl
    {

        public navbar()
        {
            InitializeComponent();
            this.Invalidate(); // Repaint the component
        }


        public void SetRouter1(Panel mainPanel, string text)
        {
            toggleRouter1.Set(text, mainPanel, @"icons8-comments-50.png");
        }

        public void SetRouter2(Panel mainPanel, string text)
        {
            toggleRouter2.Set(text, mainPanel, @"icons8-comments-50.png");
        }

        public void SetRouter3(Panel mainPanel, string text)
        {
            toggleRouter3.Set(text, mainPanel, @"icons8-comments-50.png");
        }

        public void SetRouter4(Panel mainPanel, string text)
        {
            toggleRouter4.Set(text, mainPanel, @"icons8-comments-50.png");
        }

        public void SetRouter5(Panel mainPanel, string text)
        {
            toggleRouter5.Set(text, mainPanel, @"icons8-comments-50.png");
        }
    }
}
