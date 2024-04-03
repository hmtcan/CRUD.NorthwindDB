namespace CRUDNorthwindDB.UI.Forms.Product
{
    partial class FrmProductSelect
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
			this.txtSearchProduct = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.list_Product_List = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MARKA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmb_Sort = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_stok = new System.Windows.Forms.TextBox();
			this.txt_ürünadi = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txt_fiyat = new System.Windows.Forms.TextBox();
			this.cmb_kategori = new System.Windows.Forms.ComboBox();
			this.cmb_marka = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// txtSearchProduct
			// 
			this.txtSearchProduct.Location = new System.Drawing.Point(554, 107);
			this.txtSearchProduct.Name = "txtSearchProduct";
			this.txtSearchProduct.Size = new System.Drawing.Size(197, 20);
			this.txtSearchProduct.TabIndex = 7;
			this.txtSearchProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchProduct_KeyUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(469, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "ÜRÜN ARA:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(292, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 31);
			this.label1.TabIndex = 5;
			this.label1.Text = "ÜRÜN LİSTESİ";
			// 
			// list_Product_List
			// 
			this.list_Product_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.list_Product_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.MARKA,
            this.columnHeader4,
            this.columnHeader5});
			this.list_Product_List.FullRowSelect = true;
			this.list_Product_List.GridLines = true;
			this.list_Product_List.HideSelection = false;
			this.list_Product_List.Location = new System.Drawing.Point(12, 147);
			this.list_Product_List.Name = "list_Product_List";
			this.list_Product_List.Size = new System.Drawing.Size(758, 291);
			this.list_Product_List.TabIndex = 4;
			this.list_Product_List.UseCompatibleStateImageBehavior = false;
			this.list_Product_List.View = System.Windows.Forms.View.Details;
			this.list_Product_List.Click += new System.EventHandler(this.list_Product_List_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 41;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ÜRÜN ADI";
			this.columnHeader2.Width = 87;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "FİYAT";
			this.columnHeader3.Width = 54;
			// 
			// MARKA
			// 
			this.MARKA.Text = "STOK";
			this.MARKA.Width = 52;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "KATEGORİ ADI";
			this.columnHeader4.Width = 198;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "MARKA ADI";
			this.columnHeader5.Width = 292;
			// 
			// cmb_Sort
			// 
			this.cmb_Sort.FormattingEnabled = true;
			this.cmb_Sort.Location = new System.Drawing.Point(156, 106);
			this.cmb_Sort.Name = "cmb_Sort";
			this.cmb_Sort.Size = new System.Drawing.Size(89, 21);
			this.cmb_Sort.TabIndex = 8;
			this.cmb_Sort.SelectedIndexChanged += new System.EventHandler(this.cmb_Sort_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "SIRALAMA SEÇİNİZ:";
			// 
			// txt_stok
			// 
			this.txt_stok.Location = new System.Drawing.Point(355, 450);
			this.txt_stok.Name = "txt_stok";
			this.txt_stok.Size = new System.Drawing.Size(125, 20);
			this.txt_stok.TabIndex = 13;
			// 
			// txt_ürünadi
			// 
			this.txt_ürünadi.Location = new System.Drawing.Point(12, 450);
			this.txt_ürünadi.Name = "txt_ürünadi";
			this.txt_ürünadi.Size = new System.Drawing.Size(145, 20);
			this.txt_ürünadi.TabIndex = 12;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnDelete.Location = new System.Drawing.Point(620, 475);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 45);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.OrangeRed;
			this.btnUpdate.Location = new System.Drawing.Point(41, 475);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(109, 45);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txt_fiyat
			// 
			this.txt_fiyat.Location = new System.Drawing.Point(176, 450);
			this.txt_fiyat.Name = "txt_fiyat";
			this.txt_fiyat.Size = new System.Drawing.Size(136, 20);
			this.txt_fiyat.TabIndex = 14;
			// 
			// cmb_kategori
			// 
			this.cmb_kategori.FormattingEnabled = true;
			this.cmb_kategori.Location = new System.Drawing.Point(513, 450);
			this.cmb_kategori.Name = "cmb_kategori";
			this.cmb_kategori.Size = new System.Drawing.Size(102, 21);
			this.cmb_kategori.TabIndex = 15;
			// 
			// cmb_marka
			// 
			this.cmb_marka.FormattingEnabled = true;
			this.cmb_marka.Location = new System.Drawing.Point(668, 450);
			this.cmb_marka.Name = "cmb_marka";
			this.cmb_marka.Size = new System.Drawing.Size(102, 21);
			this.cmb_marka.TabIndex = 16;
			// 
			// frmProductSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 532);
			this.Controls.Add(this.cmb_marka);
			this.Controls.Add(this.cmb_kategori);
			this.Controls.Add(this.txt_fiyat);
			this.Controls.Add(this.txt_stok);
			this.Controls.Add(this.txt_ürünadi);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmb_Sort);
			this.Controls.Add(this.txtSearchProduct);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.list_Product_List);
			this.Name = "frmProductSelect";
			this.Text = "frmProductSelect";
			this.Load += new System.EventHandler(this.frmProductSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_Product_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader MARKA;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmb_Sort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_ürünadi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.ComboBox cmb_marka;
    }
}