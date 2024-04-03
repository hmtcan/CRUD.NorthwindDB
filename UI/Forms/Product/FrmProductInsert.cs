using CRUDNorthwindDB.BusinessLayer;
using CRUDNorthwindDB.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUDNorthwindDB.UI.Forms.Product
{
	public partial class FrmProductInsert : Form
	{
		public FrmProductInsert()
		{
			InitializeComponent();
		}

		private void FrmProductInsert_Load(object sender, EventArgs e)
		{
			FillCategoryCombobox();
			FillSupplierCombobox();
		}
		void FillCategoryCombobox()
		{
			Cls_Category cls_Category = new Cls_Category();
			SqlDataReader sdr = cls_Category.SelectByCategoryName();
			while (sdr.Read())
			{
				// cmb_CategoryID.Items.Add(sdr["CategoryName"]);
				cmb_CategoryID.Items.Add(sdr[1]);
			}
		}

		void FillSupplierCombobox()
		{
			Cls_Supplier cls_Supplier = new Cls_Supplier();
			SqlDataReader sdr = cls_Supplier.SelectBySupplierName();
			while (sdr.Read())
			{
				// cmb_SupplierID.Items.Add(sdr["CategoryName"]);
				cmb_SupplierID.Items.Add(sdr[1]);
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			Cls_Product cls_Product = new Cls_Product();

			cls_Product.ProductName = txt_ProductName.Text;
			cls_Product.UnitsInStock = Convert.ToInt32(txt_UnitsInStock.Text);
			cls_Product.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);
			cls_Product.CategoryID = cmb_CategoryID.SelectedIndex + 1;
			cls_Product.SupplierID = cmb_SupplierID.SelectedIndex + 1;

			bool result = cls_Product.Save();

			if (result == true)
			{
				MessageBox.Show(Common_Messages.Common_Message_Metod("Ürün", true, "insert"));
			}
			else
			{
				MessageBox.Show(Common_Messages.Common_Message_Metod("Ürün", false, "insert"));
			}

			clear();
		}
		void clear()
		{
			txt_UnitPrice.Text = txt_ProductName.Text = txt_UnitsInStock.Text = "";
			cmb_CategoryID.SelectedIndex = -1;
			cmb_SupplierID.SelectedIndex = -1;
		}


	}

}