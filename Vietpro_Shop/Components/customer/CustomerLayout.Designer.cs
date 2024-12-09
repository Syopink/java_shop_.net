namespace Vietpro_Shop.Components.customer
{
    partial class CustomerLayout
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
            this.customerNavbar1 = new Vietpro_Shop.Components.customer.CustomerUtil.CustomerNavbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // customerNavbar1
            // 
            this.customerNavbar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerNavbar1.Location = new System.Drawing.Point(-2, 1);
            this.customerNavbar1.Name = "customerNavbar1";
            this.customerNavbar1.Size = new System.Drawing.Size(1580, 72);
            this.customerNavbar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(41, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 644);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerNavbar1);
            this.Name = "CustomerLayout";
            this.Text = "CustomerLayout";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomerUtil.CustomerNavbar customerNavbar1;
        private System.Windows.Forms.Panel panel1;
    }
}