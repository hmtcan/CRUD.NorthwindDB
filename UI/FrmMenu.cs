using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDNorthwindDB.UI.Forms.Category;
using CRUDNorthwindDB.UI.Forms.Supplier;
using CRUDNorthwindDB.UI.Forms.Product;

namespace CRUDNorthwindDB.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void kategoriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoryInsert frmCategoryInsert = new FrmCategoryInsert();
            frmCategoryInsert.ShowDialog();
        }

        private void markaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplierInsert frmSupplierInsert = new FrmSupplierInsert();
            frmSupplierInsert.ShowDialog();
        }

        private void ürünGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductInsert frmProductInsert = new FrmProductInsert();
            frmProductInsert.ShowDialog();
        }

        private void kATEGORİLİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorySelect frmCategorySelect = new FrmCategorySelect();
            frmCategorySelect.ShowDialog();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductSelect frmProductSelect = new FrmProductSelect();
            frmProductSelect.ShowDialog();
        }

		private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
            FrmSupplierSelect frmSupplierSelect = new FrmSupplierSelect();
            frmSupplierSelect.ShowDialog();
		}

		private void FrmMenu_Load(object sender, EventArgs e)
		{

		}
	}
}
