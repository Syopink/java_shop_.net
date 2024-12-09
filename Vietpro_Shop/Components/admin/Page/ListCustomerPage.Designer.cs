namespace Vietpro_Shop.Components.admin.Page
{
    partial class ListCustomerPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.cate = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectAll = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(23, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 426);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rowCustomer1
            // 
            
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(115, 221);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(481, 72);
            this.name.TabIndex = 15;
            this.name.Text = "Họ và tên";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // cate
            // 
            this.cate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate.Location = new System.Drawing.Point(590, 221);
            this.cate.Name = "cate";
            this.cate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cate.Size = new System.Drawing.Size(527, 72);
            this.cate.TabIndex = 14;
            this.cate.Text = "Email";
            this.cate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cate.Click += new System.EventHandler(this.cate_Click);
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(26, 221);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(96, 72);
            this.id.TabIndex = 13;
            this.id.Text = "ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1115, 221);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(216, 72);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hanh động";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // selectAll
            // 
            this.selectAll.Location = new System.Drawing.Point(957, 108);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(75, 23);
            this.selectAll.TabIndex = 18;
            this.selectAll.Text = "chọn tất";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(1071, 108);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(75, 23);
            this.deleteAll.TabIndex = 19;
            this.deleteAll.Text = "xóa";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(1182, 108);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(75, 23);
            this.restore.TabIndex = 20;
            this.restore.Text = "Khôi phục";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 49);
            this.textBox1.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search.Location = new System.Drawing.Point(744, 46);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 49);
            this.search.TabIndex = 1;
            this.search.Text = "Tìm";
            this.search.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(26, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 125);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách hàng ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restore);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ListCustomerPage";
            this.Size = new System.Drawing.Size(1407, 748);
            this.Load += new System.EventHandler(this.ListCustomerPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label cate;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
