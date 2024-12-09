namespace Vietpro_Shop.Components.customer.CustomerDialog
{
    partial class CustomerProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.sb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.descriptions = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.cateBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(199, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mô tả :";
            // 
            // lb4
            // 
            this.lb4.Location = new System.Drawing.Point(199, 176);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(137, 39);
            this.lb4.TabIndex = 10;
            this.lb4.Text = "Giá :";
            // 
            // sb3
            // 
            this.sb3.Location = new System.Drawing.Point(199, 116);
            this.sb3.Name = "sb3";
            this.sb3.Size = new System.Drawing.Size(137, 39);
            this.sb3.TabIndex = 9;
            this.sb3.Text = "Trạng thái";
            // 
            // lb2
            // 
            this.lb2.Location = new System.Drawing.Point(199, 67);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(137, 39);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Danh mục :";
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // lb1
            // 
            this.lb1.Location = new System.Drawing.Point(199, 10);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(113, 39);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Tên sản phẩm : ";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // descriptions
            // 
            this.descriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptions.Location = new System.Drawing.Point(318, 233);
            this.descriptions.Name = "descriptions";
            this.descriptions.Size = new System.Drawing.Size(326, 164);
            this.descriptions.TabIndex = 15;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(318, 176);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(326, 39);
            this.price.TabIndex = 11;
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Location = new System.Drawing.Point(318, 116);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(326, 39);
            this.status.TabIndex = 14;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(318, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(326, 39);
            this.name.TabIndex = 12;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Image = global::Vietpro_Shop.Properties.Resources.icons8_image_80;
            this.image.Location = new System.Drawing.Point(1, 9);
            this.image.Name = "image";
            this.image.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.image.Size = new System.Drawing.Size(176, 206);
            this.image.TabIndex = 6;
            this.image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cateBox
            // 
            this.cateBox.FormattingEnabled = true;
            this.cateBox.Location = new System.Drawing.Point(318, 67);
            this.cateBox.Name = "cateBox";
            this.cateBox.Size = new System.Drawing.Size(326, 24);
            this.cateBox.TabIndex = 17;
            // 
            // CustomerProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cateBox);
            this.Controls.Add(this.descriptions);
            this.Controls.Add(this.status);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.sb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label1);
            this.Name = "CustomerProductDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label sb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label descriptions;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.ComboBox cateBox;
    }
}