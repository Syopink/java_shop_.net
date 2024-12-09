using System.Reflection.Emit;
using Vietpro_Shop.Models;

namespace Vietpro_Shop.Components.rows
{
    partial class rowCate
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
        /// 

        
        private void InitializeComponent()
        {
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.updateText = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.idCate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(1192, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 72);
            this.delete.TabIndex = 19;
            this.delete.Text = "D";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Cyan;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.Location = new System.Drawing.Point(1111, 0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 72);
            this.update.TabIndex = 18;
            this.update.Text = "U";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(90, 0);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(481, 72);
            this.name.TabIndex = 17;
            this.name.Text = "Tên cate";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateText
            // 
            this.updateText.Location = new System.Drawing.Point(90, 0);
            this.updateText.Multiline = true;
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(481, 68);
            this.updateText.TabIndex = 20;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.GreenYellow;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.confirm.Location = new System.Drawing.Point(1111, 0);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 72);
            this.confirm.TabIndex = 21;
            this.confirm.Text = "c";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // idCate
            // 
            this.idCate.Location = new System.Drawing.Point(4, 0);
            this.idCate.Name = "idCate";
            this.idCate.Size = new System.Drawing.Size(80, 72);
            this.idCate.TabIndex = 22;
            this.idCate.Text = "label1";
            // 
            // rowCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idCate);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.name);
            this.Name = "rowCate";
            this.Size = new System.Drawing.Size(1274, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        
        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label idCate;
    }
}
