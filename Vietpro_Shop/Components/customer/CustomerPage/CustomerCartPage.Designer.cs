namespace Vietpro_Shop.Components.customer.CustomerPage
{
    partial class CustomerCartPage
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
            this.selectAll = new System.Windows.Forms.Button();
            this.buyAll = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.customerCardCart1 = new Vietpro_Shop.Components.customer.CustomerCard.CustomerCardCart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectAll
            // 
            this.selectAll.Location = new System.Drawing.Point(651, 44);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(135, 51);
            this.selectAll.TabIndex = 0;
            this.selectAll.Text = "Chọn tất";
            this.selectAll.UseVisualStyleBackColor = true;
            // 
            // buyAll
            // 
            this.buyAll.Location = new System.Drawing.Point(820, 44);
            this.buyAll.Name = "buyAll";
            this.buyAll.Size = new System.Drawing.Size(135, 51);
            this.buyAll.TabIndex = 1;
            this.buyAll.Text = "mua tất";
            this.buyAll.UseVisualStyleBackColor = true;
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(993, 44);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(135, 51);
            this.deleteAll.TabIndex = 2;
            this.deleteAll.Text = "Xóa tất ";
            this.deleteAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.customerCardCart1);
            this.panel1.Location = new System.Drawing.Point(44, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 517);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền : ";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(183, 24);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(49, 29);
            this.totalPrice.TabIndex = 5;
            this.totalPrice.Text = "???";
            // 
            // customerCardCart1
            // 
            this.customerCardCart1.Location = new System.Drawing.Point(3, 0);
            this.customerCardCart1.Name = "customerCardCart1";
            this.customerCardCart1.Size = new System.Drawing.Size(1077, 205);
            this.customerCardCart1.TabIndex = 0;
            // 
            // CustomerCartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.buyAll);
            this.Controls.Add(this.selectAll);
            this.Name = "CustomerCartPage";
            this.Size = new System.Drawing.Size(1182, 704);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button buyAll;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPrice;
        private CustomerCard.CustomerCardCart customerCardCart1;
    }
}
