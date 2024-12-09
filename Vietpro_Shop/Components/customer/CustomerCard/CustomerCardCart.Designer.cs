namespace Vietpro_Shop.Components.customer.CustomerCard
{
    partial class CustomerCardCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.image = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.sb3 = new System.Windows.Forms.Label();
            this.cate = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Image = global::Vietpro_Shop.Properties.Resources.icons8_image_80;
            this.image.Location = new System.Drawing.Point(3, 0);
            this.image.Name = "image";
            this.image.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.image.Size = new System.Drawing.Size(176, 206);
            this.image.TabIndex = 6;
            this.image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.Location = new System.Drawing.Point(185, 1);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(113, 39);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "Tên sản phẩm : ";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(301, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(281, 39);
            this.name.TabIndex = 13;
            // 
            // lb4
            // 
            this.lb4.Location = new System.Drawing.Point(185, 50);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(137, 39);
            this.lb4.TabIndex = 14;
            this.lb4.Text = "Giá :";
            // 
            // lb2
            // 
            this.lb2.Location = new System.Drawing.Point(185, 103);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(137, 39);
            this.lb2.TabIndex = 15;
            this.lb2.Text = "Danh mục :";
            // 
            // sb3
            // 
            this.sb3.Location = new System.Drawing.Point(185, 158);
            this.sb3.Name = "sb3";
            this.sb3.Size = new System.Drawing.Size(137, 39);
            this.sb3.TabIndex = 16;
            this.sb3.Text = "Trạng thái";
            // 
            // cate
            // 
            this.cate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cate.Location = new System.Drawing.Point(301, 103);
            this.cate.Name = "cate";
            this.cate.Size = new System.Drawing.Size(281, 39);
            this.cate.TabIndex = 17;
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Location = new System.Drawing.Point(301, 158);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(281, 39);
            this.status.TabIndex = 18;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(301, 50);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(281, 39);
            this.price.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(588, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số lượng :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(665, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(152, 22);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(857, 21);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(136, 62);
            this.update.TabIndex = 23;
            this.update.Text = "Mua";
            this.update.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(857, 103);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(136, 62);
            this.delete.TabIndex = 24;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1043, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CustomerCardCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.status);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.sb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.image);
            this.Name = "CustomerCardCart";
            this.Size = new System.Drawing.Size(1074, 205);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label image;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label sb3;
        private System.Windows.Forms.Label cate;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
