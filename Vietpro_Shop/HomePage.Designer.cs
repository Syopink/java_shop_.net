namespace Vietpro_Shop
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navbar1 = new Vietpro_Shop.Controllers.navbar();
            this.userControl1 = new Vietpro_Shop.Controllers.UserControl1();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(292, 79);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1328, 593);
            this.mainPanel.TabIndex = 0;
            // 
            // navbar1
            // 
            this.navbar1.BackColor = System.Drawing.Color.DarkBlue;
            this.navbar1.Location = new System.Drawing.Point(2, 79);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(284, 644);
            this.navbar1.TabIndex = 2;
            // 
            // userControl1
            // 
            this.userControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.userControl1.Location = new System.Drawing.Point(2, -4);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(1630, 77);
            this.userControl1.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 684);
            this.Controls.Add(this.navbar1);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #region Designer variables
        private System.Windows.Forms.Panel mainPanel;
        private Controllers.UserControl1 userControl1;
        #endregion

        private Controllers.navbar navbar1;
    }
}
