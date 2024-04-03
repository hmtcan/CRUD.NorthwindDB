using CRUDNorthwindDB.BusinessLayer;
using CRUDNorthwindDB.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUDNorthwindDB.UI.Forms.Category
{
    public partial class FrmCategoryInsert : Form
    {
        public FrmCategoryInsert()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool result = Cls_Category.Save(txt_Category_Name.Text, txt_Description.Text);
            if (result == true)
            {
                MessageBox.Show(Common_Messages.Common_Message_Metod("Kategori", true, "insert"));
            }
            else
            {
                MessageBox.Show(Common_Messages.Common_Message_Metod("Kategori", false, "insert"));
            }
            clear();
        }

        void clear()
        {
            txt_Category_Name.Text = txt_Description.Text = "";
        }
    }
}
