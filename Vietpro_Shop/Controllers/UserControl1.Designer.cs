namespace Vietpro_Shop.Controllers
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.Avatar = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Avatar.Image = ((System.Drawing.Image)(resources.GetObject("Avatar.Image")));
            this.Avatar.Location = new System.Drawing.Point(1495, 1);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(80, 77);
            this.Avatar.TabIndex = 0;
            this.Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.username.Location = new System.Drawing.Point(1400, 16);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(67, 16);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.label2_Click);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.role.Location = new System.Drawing.Point(1437, 47);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(30, 16);
            this.role.TabIndex = 2;
            this.role.Text = "role";
            this.role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.role.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Image = global::Vietpro_Shop.Properties.Resources.logoVietpro;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 47);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(71, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "VietPro Dashboard";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Avatar);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1578, 77);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Avatar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
