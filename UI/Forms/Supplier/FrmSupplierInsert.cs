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

namespace CRUDNorthwindDB.UI.Forms.Supplier
{
    public partial class FrmSupplierInsert : Form
    {
        public FrmSupplierInsert()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Cls_Supplier cls_Supplier = new Cls_Supplier(); // metod static değil
            cls_Supplier.CompanyName = txt_CompanyName.Text;
            cls_Supplier.Address = txt_ContactName.Text;
            bool result = cls_Supplier.Save();

            if (result == true)
            {
                MessageBox.Show(Common_Messages.Common_Message_Metod("Marka", true, "insert"));
            }
            else
            {
                MessageBox.Show(Common_Messages.Common_Message_Metod("Marka", false, "insert"));
            }
            clear();
        }
        void clear()
        {
            txt_CompanyName.Text = txt_ContactName.Text = "";
        }
    }
}
