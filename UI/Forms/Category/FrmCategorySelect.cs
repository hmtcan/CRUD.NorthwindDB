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

namespace CRUDNorthwindDB.UI.Forms.Category
{
    public partial class FrmCategorySelect : Form
    {
        public FrmCategorySelect()
        {
            InitializeComponent();
        }


        private void FrmCategorySelect_Load(object sender, EventArgs e)
        {
            FillCategoryListView();
        }

            void FillCategoryListView()
            {
                Cls_Category cls_Category = new Cls_Category();
                SqlDataReader sdr = cls_Category.SelectByCategoryName();
                list_Category_List.Items.Clear();

                while (sdr.Read())
                {
                    // cmb_CategoryID.Items.Add(sdr["CategoryName"]);
                    //cmb_CategoryID.Items.Add(sdr[1]);

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = sdr[0].ToString();
                    listViewItem.SubItems.Add(sdr[1].ToString());
                    listViewItem.SubItems.Add(sdr[2].ToString());

                    list_Category_List.Items.Add(listViewItem);

            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByCatergoryName(txtSearch.Text);
        }

            void SearchByCatergoryName(string Search)
            { 
           
                Cls_Category cls_Category = new Cls_Category();
                SqlDataReader sdr = cls_Category.SearchByCategoryName(txtSearch.Text);
                list_Category_List.Items.Clear();

                while (sdr.Read())
                {
                    // cmb_CategoryID.Items.Add(sdr["CategoryName"]);
                    //cmb_CategoryID.Items.Add(sdr[1]);
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = sdr[0].ToString();
                    listViewItem.SubItems.Add(sdr[1].ToString());
                    listViewItem.SubItems.Add(sdr[2].ToString());

                    list_Category_List.Items.Add(listViewItem);

                }
            }

        int listviewID = 0;
        private void list_Category_List_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("DENEME");

            listviewID = Convert.ToInt32(list_Category_List.FocusedItem.SubItems[0].Text);
            txt_adi.Text = list_Category_List.FocusedItem.SubItems[1].Text;
            txt_aciklama.Text = list_Category_List.FocusedItem.SubItems[2].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                Cls_Category cls_Category = new Cls_Category();
                cls_Category.CategoryID = listviewID;
                cls_Category.CategoryName = txt_adi.Text;
                cls_Category.Description = txt_aciklama.Text;


                bool result = cls_Category.Update();
                if (result == true)
                {
                    FillCategoryListView();
                    MessageBox.Show(Common_Messages.Common_Message_Metod("Kategori", true, "update"));
                }
                else
                {
                    MessageBox.Show(Common_Messages.Common_Message_Metod("Kategori", false, "update"));
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
            txt_adi.Text = txt_aciklama.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                Cls_Category cls_Category = new Cls_Category();
                cls_Category.CategoryID = listviewID;
              

                bool result = cls_Category.Delete();
                if (result == true)
                {
                    FillCategoryListView();
                    MessageBox.Show(Common_Messages.Common_Message_Metod("Kategori", true, "delete"));
                }
                else
                {
                    MessageBox.Show(Common_Messages.Common_Message_Metod("Kategori", false, "delete"));
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
