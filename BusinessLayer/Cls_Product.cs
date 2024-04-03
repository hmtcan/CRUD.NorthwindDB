using CRUDNorthwindDB.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace CRUDNorthwindDB.BusinessLayer
{
	public class Cls_Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int UnitsInStock { get; set; }
		public decimal UnitPrice { get; set; }
		public int CategoryID { get; set; }
		public int SupplierID { get; set; }

		public bool Save()
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("sp_product_insert", sqlcon);
				sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;



				sqlcmd.Parameters.AddWithValue("@ProductName", ProductName);
				sqlcmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);
				sqlcmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
				sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);
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

		public SqlDataReader SelectByProductName()
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("select * from vw_urun_listesi", sqlcon);
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

		public SqlDataReader SearchByProductName(string Search)
		{
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("select p.ProductID, p.productName, p.UnitPrice, p.UnitsInStock, c.CategoryName, s.CompanyName from Products as p inner join Categories as c on p.CategoryID = c.CategoryID inner join Suppliers as s on p.SupplierID = s.SupplierID where p.ProductName like '%" + Search + "%'", sqlcon);
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

		public SqlDataReader SortBy(string Search)
		{
			string query = "";

			if (Search == "AD")
			{
				query = "ProductName";
			}
			else if (Search == "FİYAT")
			{
				query = "UnitPrice";
			}
			else if (Search == "KATEGORİ")
			{
				query = "CategoryName";
			}
			else if (Search == "MARKA")
			{
				query = "CompanyName";
			}
			else
			{
				query = "UnitsInStock";
			}
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("select p.ProductID, p.productName, p.UnitPrice, p.UnitsInStock, c.CategoryName, s.CompanyName from Products as p inner join Categories as c on p.CategoryID = c.CategoryID inner join Suppliers as s on p.SupplierID = s.SupplierID order by " + query, sqlcon);
				sqlcon.Open();

				SqlDataReader sdr = sqlcmd.ExecuteReader();
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
				SqlCommand sqlcmd = new SqlCommand("sp_product_update", sqlcon);
				sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

				sqlcmd.Parameters.AddWithValue("@ProductName", ProductName);
				sqlcmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
				sqlcmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);
				sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);
				sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);
				sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);


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
				SqlCommand sqlcmd = new SqlCommand("sp_product_delete", sqlcon);
				sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

				sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);

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