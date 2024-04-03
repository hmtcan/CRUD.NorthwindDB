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

namespace CRUDNorthwindDB.UI.Forms.Supplier
{
	public partial class FrmSupplierSelect : Form
	{
		public FrmSupplierSelect()
		{
			InitializeComponent();
		}


		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (listviewID > 0)
			{
				Cls_Supplier cls_Supplier = new Cls_Supplier();
				cls_Supplier.SupplierID = listviewID;
				cls_Supplier.CompanyName = txt_adi.Text;
				cls_Supplier.Address = txt_adres.Text;


				bool result = cls_Supplier.Update();
				if (result == true)
				{
					FillSupplierListView();
					MessageBox.Show(Common_Messages.Common_Message_Metod("Marka", true, "update"));
				}
				else
				{
					MessageBox.Show(Common_Messages.Common_Message_Metod("Marka", false, "update"));
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
			txt_adi.Text = txt_adres.Text = "";
		}


		private void FrmSupplierSelect_Load(object sender, EventArgs e)
		{
			FillSupplierListView();
		}

		void FillSupplierListView()
		{
			Cls_Supplier cls_Supplier = new Cls_Supplier();
			SqlDataReader sdr = cls_Supplier.SelectBySupplierName();
			list_Supplier_List.Items.Clear();

			while (sdr.Read())
			{
				// cmb_CategoryID.Items.Add(sdr["CategoryName"]);
				//cmb_CategoryID.Items.Add(sdr[1]);

				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = sdr[0].ToString();
				listViewItem.SubItems.Add(sdr[1].ToString());
				listViewItem.SubItems.Add(sdr[2].ToString());

				list_Supplier_List.Items.Add(listViewItem);

			}
		}

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			SelectBySupplierName(txtSearch.Text);

		}

		void SelectBySupplierName(string Search)
		{
			Cls_Supplier cls_Supplier = new Cls_Supplier();
			SqlDataReader sdr = cls_Supplier.SelectBySupplierName(txtSearch.Text);
			list_Supplier_List.Items.Clear();

			while (sdr.Read())
			{
			
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = sdr[0].ToString();
				listViewItem.SubItems.Add(sdr[1].ToString());
				listViewItem.SubItems.Add(sdr[2].ToString());

				list_Supplier_List.Items.Add(listViewItem);

			}
		}

		int listviewID = 0;

		private void list_Supplier_List_Click(object sender, EventArgs e)
		{
			listviewID = Convert.ToInt32(list_Supplier_List.FocusedItem.SubItems[0].Text);
			txt_adi.Text = list_Supplier_List.FocusedItem.SubItems[1].Text;
			txt_adres.Text = list_Supplier_List.FocusedItem.SubItems[2].Text;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (listviewID > 0)
			{
				Cls_Supplier cls_Supplier = new Cls_Supplier();
				cls_Supplier.SupplierID = listviewID;


				bool result = cls_Supplier.Delete();
				if (result == true)
				{
					FillSupplierListView();
					MessageBox.Show(Common_Messages.Common_Message_Metod("Marka", true, "delete"));
				}
				else
				{
					MessageBox.Show(Common_Messages.Common_Message_Metod("Marka", false, "delete"));
				}
				clear();
			}
			else
			{
				MessageBox.Show(Common_Messages.liste_secim_yapilamadi);
			}

		
	}
	}
}
