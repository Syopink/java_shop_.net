namespace Vietpro_Shop.Components.dialog
{
    partial class updateProduct
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
            this.lb4 = new System.Windows.Forms.Label();
            this.sb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choose = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb4
            // 
            this.lb4.Location = new System.Drawing.Point(204, 173);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(125, 39);
            this.lb4.TabIndex = 21;
            this.lb4.Text = "Giá :";
            this.lb4.Click += new System.EventHandler(this.lb4_Click);
            // 
            // sb3
            // 
            this.sb3.Location = new System.Drawing.Point(204, 119);
            this.sb3.Name = "sb3";
            this.sb3.Size = new System.Drawing.Size(137, 39);
            this.sb3.TabIndex = 20;
            this.sb3.Text = "Trạng thái";
            this.sb3.Click += new System.EventHandler(this.sb3_Click);
            // 
            // lb2
            // 
            this.lb2.Location = new System.Drawing.Point(204, 62);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(137, 39);
            this.lb2.TabIndex = 19;
            this.lb2.Text = "Danh mục :";
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // lb1
            // 
            this.lb1.Location = new System.Drawing.Point(204, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(113, 39);
            this.lb1.TabIndex = 18;
            this.lb1.Text = "Tên sản phẩm : ";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(204, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mô tả : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Image = global::Vietpro_Shop.Properties.Resources.icons8_image_80;
            this.image.Location = new System.Drawing.Point(12, 9);
            this.image.Name = "image";
            this.image.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.image.Size = new System.Drawing.Size(176, 206);
            this.image.TabIndex = 17;
            this.image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(333, 230);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(341, 39);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(333, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(341, 22);
            this.textBox4.TabIndex = 26;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(333, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(341, 22);
            this.textBox5.TabIndex = 27;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(22, 233);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(147, 39);
            this.choose.TabIndex = 29;
            this.choose.Text = "chọn file";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(527, 332);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(147, 39);
            this.confirm.TabIndex = 30;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // updateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.sb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label1);
            this.Name = "updateProduct";
            this.Text = "updateProduct";
            this.Load += new System.EventHandler(this.updateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label sb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button confirm;
    }
}