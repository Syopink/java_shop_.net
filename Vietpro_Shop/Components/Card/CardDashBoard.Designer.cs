namespace Vietpro_Shop.Components.Card
{
    partial class CardDashBoard
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
            this.Title = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.context = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.image);
            this.panel1.Controls.Add(this.context);
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 163);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(23, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(186, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number.Location = new System.Drawing.Point(26, 76);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(186, 31);
            this.number.TabIndex = 1;
            this.number.Text = "Number";
            this.number.Click += new System.EventHandler(this.number_Click);
            // 
            // context
            // 
            this.context.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.context.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.context.Location = new System.Drawing.Point(31, 122);
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(186, 22);
            this.context.TabIndex = 2;
            this.context.Text = "Context";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.Image = global::Vietpro_Shop.Properties.Resources.icons8_image_80;
            this.image.Location = new System.Drawing.Point(189, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(140, 163);
            this.image.TabIndex = 3;
            // 
            // CardDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CardDashBoard";
            this.Size = new System.Drawing.Size(329, 163);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label context;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label image;
    }
}
