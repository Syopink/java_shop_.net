namespace Vietpro_Shop.Components.rows
{
    partial class rowCustomer
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
            this.idProduct = new System.Windows.Forms.Label();
            this.cate = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idProduct
            // 
            this.idProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProduct.Location = new System.Drawing.Point(-144, 5);
            this.idProduct.Name = "idProduct";
            this.idProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idProduct.Size = new System.Drawing.Size(128, 63);
            this.idProduct.TabIndex = 8;
            this.idProduct.Text = "ID";
            this.idProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cate
            // 
            this.cate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate.Location = new System.Drawing.Point(567, 0);
            this.cate.Name = "cate";
            this.cate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cate.Size = new System.Drawing.Size(527, 72);
            this.cate.TabIndex = 11;
            this.cate.Text = "Email";
            this.cate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(3, 0);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(96, 72);
            this.id.TabIndex = 9;
            this.id.Text = "ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.id.Click += new System.EventHandler(this.name_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(92, 0);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(481, 72);
            this.name.TabIndex = 12;
            this.name.Text = "Họ và tên";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Cyan;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.Location = new System.Drawing.Point(1113, 6);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 62);
            this.update.TabIndex = 13;
            this.update.Text = "U";
            this.update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1194, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 14;
            this.button2.Text = "D";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rowCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idProduct);
            this.Name = "rowCustomer";
            this.Size = new System.Drawing.Size(1299, 72);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label idProduct;
        private System.Windows.Forms.Label cate;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button2;
    }
}
