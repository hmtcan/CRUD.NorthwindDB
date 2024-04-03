namespace CRUDNorthwindDB.UI.Forms.Category
{
    partial class FrmCategoryInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Category_Name = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATEGORİ GİRİŞ FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "KATEGORİ ADI:";
            // 
            // txt_Category_Name
            // 
            this.txt_Category_Name.Location = new System.Drawing.Point(258, 134);
            this.txt_Category_Name.MaxLength = 50;
            this.txt_Category_Name.Name = "txt_Category_Name";
            this.txt_Category_Name.Size = new System.Drawing.Size(146, 20);
            this.txt_Category_Name.TabIndex = 2;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(258, 181);
            this.txt_Description.MaxLength = 100;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(146, 20);
            this.txt_Description.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "AÇIKLAMA:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(257, 269);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(147, 75);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FrmCategoryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 388);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Category_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategoryInsert";
            this.Text = "FrmCategoryInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Category_Name;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
    }
}