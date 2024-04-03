namespace CRUDNorthwindDB.UI.Forms.Supplier
{
	partial class FrmSupplierSelect
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
			this.txt_adres = new System.Windows.Forms.TextBox();
			this.txt_adi = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.list_Supplier_List = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// txt_adres
			// 
			this.txt_adres.Location = new System.Drawing.Point(528, 409);
			this.txt_adres.Name = "txt_adres";
			this.txt_adres.Size = new System.Drawing.Size(204, 20);
			this.txt_adres.TabIndex = 15;
			// 
			// txt_adi
			// 
			this.txt_adi.Location = new System.Drawing.Point(111, 409);
			this.txt_adi.Name = "txt_adi";
			this.txt_adi.Size = new System.Drawing.Size(193, 20);
			this.txt_adi.TabIndex = 14;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnDelete.Location = new System.Drawing.Point(579, 435);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 45);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.OrangeRed;
			this.btnUpdate.Location = new System.Drawing.Point(152, 435);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(109, 45);
			this.btnUpdate.TabIndex = 12;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(267, 57);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(197, 20);
			this.txtSearch.TabIndex = 11;
			this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(171, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "MARKA ARA:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(280, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 31);
			this.label1.TabIndex = 9;
			this.label1.Text = "MARKA LİSTESİ";
			// 
			// list_Supplier_List
			// 
			this.list_Supplier_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.list_Supplier_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.list_Supplier_List.FullRowSelect = true;
			this.list_Supplier_List.GridLines = true;
			this.list_Supplier_List.HideSelection = false;
			this.list_Supplier_List.Location = new System.Drawing.Point(101, 100);
			this.list_Supplier_List.Name = "list_Supplier_List";
			this.list_Supplier_List.Size = new System.Drawing.Size(631, 291);
			this.list_Supplier_List.TabIndex = 8;
			this.list_Supplier_List.UseCompatibleStateImageBehavior = false;
			this.list_Supplier_List.View = System.Windows.Forms.View.Details;
			this.list_Supplier_List.Click += new System.EventHandler(this.list_Supplier_List_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 41;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "MARKA ADI";
			this.columnHeader2.Width = 223;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ADRES";
			this.columnHeader3.Width = 207;
			// 
			// FrmSupplierSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 490);
			this.Controls.Add(this.txt_adres);
			this.Controls.Add(this.txt_adi);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.list_Supplier_List);
			this.Name = "FrmSupplierSelect";
			this.Text = "FrmSupplierSelect";
			this.Load += new System.EventHandler(this.FrmSupplierSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_adres;
		private System.Windows.Forms.TextBox txt_adi;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView list_Supplier_List;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}