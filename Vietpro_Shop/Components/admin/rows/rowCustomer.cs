using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vietpro_Shop.Components.rows
{
    public partial class rowCustomer : UserControl
    {
        public rowCustomer()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        public List<string> CateList(List<object[]> categories)
        {
            List<string> cateList = new List<string>();
            foreach (var row in categories)
            {
                string nameCate = row[1].ToString();
                cateList.Add(nameCate);
            }
            return cateList;
        }



        public void set() { 
        
        }
    }
}
