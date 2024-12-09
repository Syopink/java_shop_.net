namespace Vietpro_Shop.Components.admin.Panel
{
    partial class ListCatePage
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
            this.listCate = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowCate1 = new Vietpro_Shop.Components.rows.rowCate();
            this.listCate.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCate
            // 
            this.listCate.AutoScroll = true;
            this.listCate.Controls.Add(this.rowCate1);
            this.listCate.Location = new System.Drawing.Point(0, 250);
            this.listCate.Name = "listCate";
            this.listCate.Size = new System.Drawing.Size(1289, 479);
            this.listCate.TabIndex = 0;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(90, 175);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(481, 72);
            this.name.TabIndex = 19;
            this.name.Text = "Tên cate";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(3, 178);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(96, 72);
            this.id.TabIndex = 18;
            this.id.Text = "ID";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1110, 178);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(183, 72);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hành động";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(481, 72);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danh sách các mục";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rowCate1
            // 
            this.rowCate1.Location = new System.Drawing.Point(0, 0);
            this.rowCate1.Name = "rowCate1";
            this.rowCate1.Size = new System.Drawing.Size(1274, 71);
            this.rowCate1.TabIndex = 0;
            // 
            // ListCatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.listCate);
            this.Name = "ListCatePage";
            this.Size = new System.Drawing.Size(1293, 732);
            this.listCate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listCate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.rows.rowCate rowCate1;
    }
}
