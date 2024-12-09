namespace Vietpro_Shop.Components.customer
{
    partial class CustomerCardProduct
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
            this.details = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.details);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.image);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 275);
            this.panel1.TabIndex = 0;
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.details.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.details.Location = new System.Drawing.Point(133, 212);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(44, 39);
            this.details.TabIndex = 3;
            this.details.Text = "D";
            this.details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.details.Click += new System.EventHandler(this.label3_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(12, 224);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(74, 27);
            this.price.TabIndex = 2;
            this.price.Text = "???";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.price.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giá :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.Image = global::Vietpro_Shop.Properties.Resources.icons8_image_80;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(197, 182);
            this.image.TabIndex = 0;
            // 
            // CustomerCardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerCardProduct";
            this.Size = new System.Drawing.Size(207, 282);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label1;
    }
}
