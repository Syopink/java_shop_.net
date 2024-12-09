using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Vietpro_Shop.Models;

namespace Vietpro_Shop.Components.rows
{
    public partial class rowCate : UserControl
    {
        private bool isUpdate = false;
        private bool isConfirm = false;
        private bool isDelete = false;
        private string idcate;
        private string title;
        ActionCate acc = new ActionCate();
        public rowCate()
        {
            InitializeComponent();
        }

        private void Set(Cate cate)
        {
            this.idcate = cate.Id.ToString();
            this.title = cate.Title.ToString();
            idCate.Text = cate.Id.ToString();
            name.Text = cate.Title.ToString();// Chuyển đổi giá trị ID sang chuỗi và gán vào idLabel
        }


        private void update_Click(object sender, EventArgs e)
        {
            this.isUpdate = !isUpdate;
            if (isUpdate == true)
            {
                updateText.Visible = true;
                confirm.Visible = true;
            }
            else {
                updateText.Visible = false;
                confirm.Visible = false;
            }

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            this.isConfirm = !isConfirm;
            if (isConfirm == true) {
                string setText = updateText.Text;
                acc.UpdateCate(int.Parse(idcate), title);
                updateText.Visible = false;
                confirm.Visible = false;

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.isDelete = !isDelete;
            if (isDelete==true) {
                acc.DeleteCate(int.Parse(idcate));
               isDelete = !isDelete;
            }
        }
    }

}
