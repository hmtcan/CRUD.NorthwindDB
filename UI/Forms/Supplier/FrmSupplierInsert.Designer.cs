namespace CRUDNorthwindDB.UI.Forms.Supplier
{
    partial class FrmSupplierInsert
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
			this.btn_Save = new System.Windows.Forms.Button();
			this.txt_ContactName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_CompanyName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.SystemColors.GrayText;
			this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Save.Location = new System.Drawing.Point(421, 295);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(147, 75);
			this.btn_Save.TabIndex = 11;
			this.btn_Save.Text = "KAYDET";
			this.btn_Save.UseVisualStyleBackColor = false;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// txt_ContactName
			// 
			this.txt_ContactName.Location = new System.Drawing.Point(422, 207);
			this.txt_ContactName.MaxLength = 100;
			this.txt_ContactName.Name = "txt_ContactName";
			this.txt_ContactName.Size = new System.Drawing.Size(146, 20);
			this.txt_ContactName.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(233, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "ADRES:";
			// 
			// txt_CompanyName
			// 
			this.txt_CompanyName.Location = new System.Drawing.Point(422, 160);
			this.txt_CompanyName.MaxLength = 50;
			this.txt_CompanyName.Name = "txt_CompanyName";
			this.txt_CompanyName.Size = new System.Drawing.Size(146, 20);
			this.txt_CompanyName.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(233, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "MARKA ADI:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(287, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "MARKA GİRİŞ FORMU";
			// 
			// FrmSupplierInsert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.txt_ContactName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_CompanyName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmSupplierInsert";
			this.Text = "FrmSupplierInsert";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_ContactName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}