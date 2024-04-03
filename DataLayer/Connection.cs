using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDNorthwindDB.DataLayer
{
	public class Connection
	{
		public static SqlConnection baglanti
		{
			get
			{
				SqlConnection sqlcon = new SqlConnection
					("Server= .;Trusted_Connection=True;Database=NORTHWND;");
				return sqlcon;
			}
		}

	}
}
