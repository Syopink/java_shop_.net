namespace Vietpro_Shop.Components.admin.rows
{
    partial class rowUser
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
            this.button2 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1105, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 18;
            this.button2.Text = "D";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Cyan;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.Location = new System.Drawing.Point(1022, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 62);
            this.update.TabIndex = 17;
            this.update.Text = "U";
            this.update.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(91, 0);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(481, 72);
            this.name.TabIndex = 16;
            this.name.Text = "Họ và tên";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(0, 0);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(96, 72);
            this.id.TabIndex = 15;
            this.id.Text = "ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(563, 0);
            this.email.Name = "email";
            this.email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email.Size = new System.Drawing.Size(453, 72);
            this.email.TabIndex = 19;
            this.email.Text = "Email";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.email);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "rowUser";
            this.Size = new System.Drawing.Size(1183, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label email;
    }
}
