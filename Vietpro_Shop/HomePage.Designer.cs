namespace Vietpro_Shop
{
    partial class HomePage
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userControl11 = new Vietpro_Shop.Controllers.UserControl1();
            this.navbar1 = new Vietpro_Shop.Controllers.navbar();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(314, 79);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1243, 588);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.userControl11.Location = new System.Drawing.Point(2, -4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1630, 77);
            this.userControl11.TabIndex = 1;
            // 
            // navbar1
            // 
            this.navbar1.BackColor = System.Drawing.Color.DarkBlue;
            this.navbar1.Location = new System.Drawing.Point(2, 79);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(285, 644);
            this.navbar1.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 684);
            this.ControlBox = false;
            this.Controls.Add(this.navbar1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.mainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private Controllers.UserControl1 userControl11;
        private Controllers.navbar navbar1;
    }
}