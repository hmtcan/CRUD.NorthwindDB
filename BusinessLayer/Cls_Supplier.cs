using CRUDNorthwindDB.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CRUDNorthwindDB.BusinessLayer
{
    public class Cls_Supplier
    {
		public int SupplierID { get; set; }

		// Kapsülleme (encapsulation)
		public string _CompanyName { get; set; }
        public string CompanyName { 
            get { return _CompanyName; }
            set { _CompanyName = value.ToUpper(); }
        }
        public string Address { get; set; }

        public bool Save()
        {
            try
            {
                SqlConnection sqlcon = Connection.baglanti;
                SqlCommand sqlcmd = new SqlCommand("insert into Suppliers (CompanyName,Address) values (@CompanyName,@Address)", sqlcon);
                sqlcmd.Parameters.AddWithValue("@CompanyName", _CompanyName);
                sqlcmd.Parameters.AddWithValue("@Address", Address);
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

		//public SqlDataReader SelectBySupplierName()
		//{
		//    try
		//    {
		//        SqlConnection sqlcon = Connection.baglanti;
		//        SqlCommand sqlcmd = new SqlCommand("Select SupplierID,CompanyName,ContactTitle from Suppliers", sqlcon);
		//        sqlcon.Open();

		//        SqlDataReader sdr = sqlcmd.ExecuteReader();
		//        //sqlcon.Close();
		//        return sdr;
		//    }
		//    catch (Exception)
		//    {
		//        return null;
		//    }
		//}

		public SqlDataReader SelectBySupplierName()
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("select * from vw_supplier_list", sqlcon);
				sqlcon.Open();

				SqlDataReader sdr = sqlcmd.ExecuteReader();
				//sqlcon.Close();
				return sdr;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public SqlDataReader SelectBySupplierName(string Search)
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("select * from Suppliers where CompanyName like '%" + Search + "%'", sqlcon);
				sqlcon.Open();

				SqlDataReader sdr = sqlcmd.ExecuteReader();
				//sqlcon.Close();
				return sdr;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool Update()
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("sp_supplier_update", sqlcon);
				sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

				sqlcmd.Parameters.AddWithValue("@CompanyName", CompanyName);
				sqlcmd.Parameters.AddWithValue("@Address", Address);
				sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);

				sqlcon.Open();
				sqlcmd.ExecuteNonQuery();
				sqlcon.Close();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Delete()
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;

				SqlCommand sqlcmd = new SqlCommand("sp_supplier_delete", sqlcon);
				sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

				sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);

				sqlcon.Open();
				sqlcmd.ExecuteNonQuery();
				sqlcon.Close();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}






	}

}

