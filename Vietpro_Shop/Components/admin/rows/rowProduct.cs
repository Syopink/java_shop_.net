using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vietpro_Shop.Models;

namespace Vietpro_Shop.Components.rows
{
    public partial class rowProduct : UserControl
    {
        private Product CurrentProduct ;
        public rowProduct()
        {
            InitializeComponent();
        }

        public void set(Product product)
        {
            this.CurrentProduct = product;
            idProduct.Text = product.Name;
            price.Text=product.Price.ToString();
            cate.Text=product.CategoryTitle.ToString();
            status.Text=product.Status.ToString();
            string imagePath = "path/to/your/image.jpg";
            image.Image=Image.FromFile(imagePath+product.Thumbnail);
        }

    }

}
