using CRUDNorthwindDB.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDNorthwindDB.BusinessLayer
{
    public class Cls_Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


        public static bool Save(string CategoryName, string Description)
        {
            try
            {
                SqlConnection sqlcon = Connection.baglanti;
                SqlCommand sqlcmd = new SqlCommand("insert into Categories (CategoryName,Description) values (@CategoryName,@Description)", sqlcon);
                sqlcmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                sqlcmd.Parameters.AddWithValue("@Description", Description);
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

        public SqlDataReader SelectByCategoryName()
        {
            try
            {
                SqlConnection sqlcon = Connection.baglanti;
                SqlCommand sqlcmd = new SqlCommand("select * from vw_kategori_listesi", sqlcon);
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
        public SqlDataReader SearchByCategoryName(string Search)
        {
            try
            {
                SqlConnection sqlcon = Connection.baglanti;
                SqlCommand sqlcmd = new SqlCommand("select * from Categories where CategoryName like '%"+ Search + "%'", sqlcon);
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
                SqlCommand sqlcmd = new SqlCommand("sp_category_update", sqlcon);
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                sqlcmd.Parameters.AddWithValue("@Description", Description);
                sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);

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

                SqlCommand sqlcmd = new SqlCommand("sp_category_delete", sqlcon);
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);

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
