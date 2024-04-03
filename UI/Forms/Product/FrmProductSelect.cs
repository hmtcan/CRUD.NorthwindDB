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
	public partial class FrmProductSelect : Form
	{
		public FrmProductSelect()
		{
			InitializeComponent();
		}


		private void frmProductSelect_Load(object sender, EventArgs e)
		{
			FillProductListview();
			Fill_Sort_Combobox();
			FillCategoryCombobox();
			FillSupplierCombobox();

		}

		void Fill_Sort_Combobox()
		{
			cmb_Sort.Items.Add("AD");
			cmb_Sort.Items.Add("FİYAT");
			cmb_Sort.Items.Add("STOK");
			cmb_Sort.Items.Add("KATEGORİ");
			cmb_Sort.Items.Add("MARKA");
		}

		void FillProductListview()
		{
			Cls_Product cls_Product = new Cls_Product();
			SqlDataReader sdr = cls_Product.SelectByProductName();
			list_Product_List.Items.Clear();

			while (sdr.Read())
			{

				//cmb_CategoryID.Items.Add(sdr[1]);
				ListViewItem listviewitem = new ListViewItem();
				//degişkeni doldurdum
				listviewitem.Text = sdr[0].ToString();
				listviewitem.SubItems.Add(sdr[1].ToString());
				listviewitem.SubItems.Add(sdr[2].ToString());
				listviewitem.SubItems.Add(sdr[3].ToString());
				listviewitem.SubItems.Add(sdr[4].ToString());
				listviewitem.SubItems.Add(sdr[5].ToString());

				//değişeni bizim listview e gönderdim.
				list_Product_List.Items.Add(listviewitem);
			}
		}

		private void txtSearchProduct_KeyUp(object sender, KeyEventArgs e)
		{
			SearchByProductName(txtSearchProduct.Text);
		}

		void SearchByProductName(string ProductName)
		{
			Cls_Product cls_Product = new Cls_Product();
			SqlDataReader sdr = cls_Product.SearchByProductName(txtSearchProduct.Text);
			list_Product_List.Items.Clear();
			while (sdr.Read())
			{
				ListViewItem listviewitem = new ListViewItem();

				//degişkeni doldurdum

				listviewitem.Text = sdr[0].ToString();
				listviewitem.SubItems.Add(sdr[1].ToString());
				listviewitem.SubItems.Add(sdr[2].ToString());
				listviewitem.SubItems.Add(sdr[3].ToString());
				listviewitem.SubItems.Add(sdr[4].ToString());
				listviewitem.SubItems.Add(sdr[5].ToString());

				//değişeni bizim listview e gönderdim.
				list_Product_List.Items.Add(listviewitem);
			}
		}

		private void cmb_Sort_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cls_Product cls_Product = new Cls_Product();
			string SearchName = cmb_Sort.SelectedItem.ToString();

			SqlDataReader sdr = cls_Product.SortBy(SearchName);
			list_Product_List.Items.Clear();
			while (sdr.Read())
			{
				ListViewItem listviewitem = new ListViewItem();

				//degişkeni doldurdum

				listviewitem.Text = sdr[0].ToString();
				listviewitem.SubItems.Add(sdr[1].ToString());
				listviewitem.SubItems.Add(sdr[2].ToString());
				listviewitem.SubItems.Add(sdr[3].ToString());
				listviewitem.SubItems.Add(sdr[4].ToString());
				listviewitem.SubItems.Add(sdr[5].ToString());

				//değişeni bizim listview e gönderdim.
				list_Product_List.Items.Add(listviewitem);
			}
		}
		int listviewID = 0;
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (listviewID > 0)
			{
				Cls_Product cls_Product = new Cls_Product();
				cls_Product.ProductID = listviewID;
				cls_Product.ProductName = txt_ürünadi.Text;
				cls_Product.UnitPrice = Convert.ToDecimal(txt_fiyat.Text);
				cls_Product.UnitsInStock = Convert.ToInt32(txt_stok.Text);
				cls_Product.CategoryID = cmb_kategori.SelectedIndex + 1;
				cls_Product.SupplierID = cmb_marka.SelectedIndex + 1;


				bool result = cls_Product.Update();
				if (result == true)
				{
					FillProductListview();
					MessageBox.Show(Common_Messages.Common_Message_Metod("Ürün", true, "update"));
				}
				else
				{
					MessageBox.Show(Common_Messages.Common_Message_Metod("Ürün", false, "update"));
				}
				clear();
			}
			else
			{
				MessageBox.Show(Common_Messages.liste_secim_yapilamadi);
			}
		}


		private void list_Product_List_Click(object sender, EventArgs e)
		{
			listviewID = Convert.ToInt32(list_Product_List.FocusedItem.SubItems[0].Text);
			txt_ürünadi.Text = list_Product_List.FocusedItem.SubItems[1].Text;
			txt_fiyat.Text = list_Product_List.FocusedItem.SubItems[2].Text;
			txt_stok.Text = list_Product_List.FocusedItem.SubItems[3].Text;
			cmb_kategori.Text = list_Product_List.FocusedItem.SubItems[4].Text;
			cmb_marka.Text = list_Product_List.FocusedItem.SubItems[5].Text;
		}

		void FillCategoryCombobox()
		{
			Cls_Category cls_Category = new Cls_Category();
			SqlDataReader sdr = cls_Category.SelectByCategoryName();
			while (sdr.Read())
			{
				// cmb_CategoryID.Items.Add(sdr["CategoryName"]);
				cmb_kategori.Items.Add(sdr[1]);
			}
		}

		void FillSupplierCombobox()
		{
			Cls_Supplier cls_Supplier = new Cls_Supplier();
			SqlDataReader sdr = cls_Supplier.SelectBySupplierName();
			while (sdr.Read())
			{
				// cmb_SupplierID.Items.Add(sdr["CategoryName"]);
				cmb_marka.Items.Add(sdr[1]);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (listviewID > 0)
			{
				Cls_Product cls_Product = new Cls_Product();
				cls_Product.ProductID = listviewID;
				cls_Product.ProductName = txt_ürünadi.Text;
				cls_Product.UnitPrice = Convert.ToDecimal(txt_fiyat.Text);
				cls_Product.UnitsInStock = Convert.ToInt32(txt_stok.Text);
				cls_Product.CategoryID = cmb_kategori.SelectedIndex + 1;
				cls_Product.SupplierID = cmb_marka.SelectedIndex + 1;


				bool result = cls_Product.Delete();
				if (result == true)
				{
					FillProductListview();
					MessageBox.Show(Common_Messages.Common_Message_Metod("Ürün", true, "delete"));
				}
				else
				{
					MessageBox.Show(Common_Messages.Common_Message_Metod("Ürün", false, "delete"));
				}
				clear();
			}
			else
			{
				MessageBox.Show(Common_Messages.liste_secim_yapilamadi);
			}
		}
		void clear()
		{
			txt_ürünadi.Text = txt_fiyat.Text = txt_stok.Text = "";
		}
	}




}
