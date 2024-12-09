using System.Drawing;

namespace Vietpro_Shop.Controllers
{
    partial class navbar
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
            this.toggleRouter5 = new Vietpro_Shop.Controllers.toggleRouter();
            this.toggleRouter4 = new Vietpro_Shop.Controllers.toggleRouter();
            this.toggleRouter3 = new Vietpro_Shop.Controllers.toggleRouter();
            this.toggleRouter2 = new Vietpro_Shop.Controllers.toggleRouter();
            this.toggleRouter1 = new Vietpro_Shop.Controllers.toggleRouter();
            this.SuspendLayout();
            // 
            // toggleRouter5
            // 
            this.toggleRouter5.Location = new System.Drawing.Point(0, 261);
            this.toggleRouter5.Name = "toggleRouter5";
            this.toggleRouter5.Size = new System.Drawing.Size(251, 56);
            this.toggleRouter5.TabIndex = 4;
            // 
            // toggleRouter4
            // 
            this.toggleRouter4.Location = new System.Drawing.Point(0, 199);
            this.toggleRouter4.Name = "toggleRouter4";
            this.toggleRouter4.Size = new System.Drawing.Size(251, 56);
            this.toggleRouter4.TabIndex = 3;
            // 
            // toggleRouter3
            // 
            this.toggleRouter3.Location = new System.Drawing.Point(0, 137);
            this.toggleRouter3.Name = "toggleRouter3";
            this.toggleRouter3.Size = new System.Drawing.Size(251, 56);
            this.toggleRouter3.TabIndex = 2;
            // 
            // toggleRouter2
            // 
            this.toggleRouter2.Location = new System.Drawing.Point(0, 75);
            this.toggleRouter2.Name = "toggleRouter2";
            this.toggleRouter2.Size = new System.Drawing.Size(251, 56);
            this.toggleRouter2.TabIndex = 1;
            // 
            // toggleRouter1
            // 
            this.toggleRouter1.Location = new System.Drawing.Point(0, 13);
            this.toggleRouter1.Name = "toggleRouter1";
            this.toggleRouter1.Size = new System.Drawing.Size(251, 56);
            this.toggleRouter1.TabIndex = 0;
            // 
            // navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.toggleRouter5);
            this.Controls.Add(this.toggleRouter4);
            this.Controls.Add(this.toggleRouter3);
            this.Controls.Add(this.toggleRouter2);
            this.Controls.Add(this.toggleRouter1);
            this.Name = "navbar";
            this.Size = new System.Drawing.Size(298, 644);
            this.ResumeLayout(false);

        }

        private toggleRouter toggleRouter1;
        private toggleRouter toggleRouter2;
        private toggleRouter toggleRouter3;
        private toggleRouter toggleRouter4;
        private toggleRouter toggleRouter5;
    }
}
