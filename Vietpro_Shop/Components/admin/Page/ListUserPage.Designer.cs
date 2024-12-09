namespace Vietpro_Shop.Components.admin.Page
{
    partial class ListUserPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rowCustomer1 = new Vietpro_Shop.Components.rows.rowCustomer();
            this.rowCustomer2 = new Vietpro_Shop.Components.rows.rowCustomer();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(33, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 125);
            this.panel2.TabIndex = 18;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 49);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách người dùng";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.rowCustomer2);
            this.panel1.Controls.Add(this.rowCustomer1);
            this.panel1.Location = new System.Drawing.Point(33, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 401);
            this.panel1.TabIndex = 19;
            // 
            // rowCustomer1
            // 
            this.rowCustomer1.Location = new System.Drawing.Point(0, 0);
            this.rowCustomer1.Name = "rowCustomer1";
            this.rowCustomer1.Size = new System.Drawing.Size(1299, 72);
            this.rowCustomer1.TabIndex = 0;
            // 
            // rowCustomer2
            // 
            this.rowCustomer2.Location = new System.Drawing.Point(0, 78);
            this.rowCustomer2.Name = "rowCustomer2";
            this.rowCustomer2.Size = new System.Drawing.Size(1299, 72);
            this.rowCustomer2.TabIndex = 1;
            // 
            // ListUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "ListUserPage";
            this.Size = new System.Drawing.Size(1432, 702);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Components.rows.rowCustomer rowCustomer1;
        private Components.rows.rowCustomer rowCustomer2;
    }
}
