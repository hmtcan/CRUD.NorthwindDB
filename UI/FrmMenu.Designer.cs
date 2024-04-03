namespace CRUDNorthwindDB.UI
{
    partial class FrmMenu
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.kATEGORİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kategoriGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kATEGORİLİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mARKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.markaGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.üRÜNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ürünGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kATEGORİToolStripMenuItem,
            this.mARKAToolStripMenuItem,
            this.üRÜNToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 45);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// kATEGORİToolStripMenuItem
			// 
			this.kATEGORİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriGirişToolStripMenuItem,
            this.kATEGORİLİSTELEToolStripMenuItem});
			this.kATEGORİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.kATEGORİToolStripMenuItem.Name = "kATEGORİToolStripMenuItem";
			this.kATEGORİToolStripMenuItem.Size = new System.Drawing.Size(150, 41);
			this.kATEGORİToolStripMenuItem.Text = "KATEGORİ";
			// 
			// kategoriGirişToolStripMenuItem
			// 
			this.kategoriGirişToolStripMenuItem.Name = "kategoriGirişToolStripMenuItem";
			this.kategoriGirişToolStripMenuItem.Size = new System.Drawing.Size(255, 42);
			this.kategoriGirişToolStripMenuItem.Text = "Kategori Giriş";
			this.kategoriGirişToolStripMenuItem.Click += new System.EventHandler(this.kategoriGirişToolStripMenuItem_Click);
			// 
			// kATEGORİLİSTELEToolStripMenuItem
			// 
			this.kATEGORİLİSTELEToolStripMenuItem.Name = "kATEGORİLİSTELEToolStripMenuItem";
			this.kATEGORİLİSTELEToolStripMenuItem.Size = new System.Drawing.Size(169, 42);
			this.kATEGORİLİSTELEToolStripMenuItem.Text = "Listele";
			this.kATEGORİLİSTELEToolStripMenuItem.Click += new System.EventHandler(this.kATEGORİLİSTELEToolStripMenuItem_Click);
			// 
			// mARKAToolStripMenuItem
			// 
			this.mARKAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaGirişToolStripMenuItem,
            this.listeleToolStripMenuItem});
			this.mARKAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.mARKAToolStripMenuItem.Name = "mARKAToolStripMenuItem";
			this.mARKAToolStripMenuItem.Size = new System.Drawing.Size(119, 41);
			this.mARKAToolStripMenuItem.Text = "MARKA";
			// 
			// markaGirişToolStripMenuItem
			// 
			this.markaGirişToolStripMenuItem.Name = "markaGirişToolStripMenuItem";
			this.markaGirişToolStripMenuItem.Size = new System.Drawing.Size(228, 42);
			this.markaGirişToolStripMenuItem.Text = "Marka Giriş";
			this.markaGirişToolStripMenuItem.Click += new System.EventHandler(this.markaGirişToolStripMenuItem_Click);
			// 
			// üRÜNToolStripMenuItem
			// 
			this.üRÜNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünGirişToolStripMenuItem,
            this.lİSTELEToolStripMenuItem});
			this.üRÜNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.üRÜNToolStripMenuItem.Name = "üRÜNToolStripMenuItem";
			this.üRÜNToolStripMenuItem.Size = new System.Drawing.Size(103, 41);
			this.üRÜNToolStripMenuItem.Text = "ÜRÜN";
			// 
			// ürünGirişToolStripMenuItem
			// 
			this.ürünGirişToolStripMenuItem.Name = "ürünGirişToolStripMenuItem";
			this.ürünGirişToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
			this.ürünGirişToolStripMenuItem.Size = new System.Drawing.Size(379, 42);
			this.ürünGirişToolStripMenuItem.Text = "Ürün Giriş";
			this.ürünGirişToolStripMenuItem.Click += new System.EventHandler(this.ürünGirişToolStripMenuItem_Click);
			// 
			// lİSTELEToolStripMenuItem
			// 
			this.lİSTELEToolStripMenuItem.Name = "lİSTELEToolStripMenuItem";
			this.lİSTELEToolStripMenuItem.Size = new System.Drawing.Size(379, 42);
			this.lİSTELEToolStripMenuItem.Text = "Listele";
			this.lİSTELEToolStripMenuItem.Click += new System.EventHandler(this.lİSTELEToolStripMenuItem_Click);
			// 
			// listeleToolStripMenuItem
			// 
			this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
			this.listeleToolStripMenuItem.Size = new System.Drawing.Size(180, 42);
			this.listeleToolStripMenuItem.Text = "Listele";
			this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARKAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİLİSTELEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lİSTELEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
	}
}