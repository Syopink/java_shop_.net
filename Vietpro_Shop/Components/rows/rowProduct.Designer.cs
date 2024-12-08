namespace Vietpro_Shop.Components.rows
{
    partial class rowProduct
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
            this.name = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.cate = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.upDe1 = new Vietpro_Shop.Components.util.UpDe();
            this.SuspendLayout();
            // 
            // idProduct
            // 
            this.idProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProduct.Location = new System.Drawing.Point(0, 0);
            this.idProduct.Name = "idProduct";
            this.idProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idProduct.Size = new System.Drawing.Size(128, 63);
            this.idProduct.TabIndex = 0;
            this.idProduct.Text = "ID";
            this.idProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(127, 0);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(263, 63);
            this.name.TabIndex = 1;
            this.name.Text = "Tên sản phẩm";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(1074, 0);
            this.status.Name = "status";
            this.status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.status.Size = new System.Drawing.Size(176, 63);
            this.status.TabIndex = 2;
            this.status.Text = "Trạng thái";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cate
            // 
            this.cate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate.Location = new System.Drawing.Point(835, 0);
            this.cate.Name = "cate";
            this.cate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cate.Size = new System.Drawing.Size(245, 63);
            this.cate.TabIndex = 3;
            this.cate.Text = "Danh mục";
            this.cate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(382, 0);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.price.Size = new System.Drawing.Size(291, 63);
            this.price.TabIndex = 4;
            this.price.Text = "Giá";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.price.Click += new System.EventHandler(this.label4_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Image = global::Vietpro_Shop.Properties.Resources.icons8_image_80;
            this.image.Location = new System.Drawing.Point(664, 0);
            this.image.Name = "image";
            this.image.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.image.Size = new System.Drawing.Size(176, 206);
            this.image.TabIndex = 5;
            this.image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upDe1
            // 
            this.upDe1.Location = new System.Drawing.Point(1256, 0);
            this.upDe1.Name = "upDe1";
            this.upDe1.Size = new System.Drawing.Size(172, 63);
            this.upDe1.TabIndex = 6;
            // 
            // rowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.upDe1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.price);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.status);
            this.Controls.Add(this.name);
            this.Controls.Add(this.idProduct);
            this.Name = "rowProduct";
            this.Size = new System.Drawing.Size(1436, 206);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label idProduct;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label cate;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label image;
        private util.UpDe upDe1;
    }
}
