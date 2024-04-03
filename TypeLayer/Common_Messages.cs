using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDNorthwindDB.TypeLayer
{
	public class Common_Messages
	{
		public static string Common_Message_Metod(string tablename, bool basarilimi, string CRUD)
		{
			string result = "";
			tablename = tablename.ToUpper();
			if (basarilimi == true)
			{
				//try = başarılı
				if (CRUD == "insert")
				{
					// başarılı yeni kayıt mesajı 
					result = tablename + " tablosuna başarıyla kaydedildi.";
				}
				else if (CRUD == "update")
				{
					// başarılı güncelleme mesajı 
					result = tablename + " tablosu başarıyla güncellendi.";

				}
				else if (CRUD == "delete")
				{
					// başarılı silme mesajı
					result = tablename + " tablosundan başarıyla silindi.";

				}
				else
				{
					// inset
					// yanlış parametreler girildi (insert, update, delete)
					result = tablename + " tablosu için try içinden yanlış " + CRUD + " parametresi";

				}
			}
			else
			{
				// catch = başarısız
				if (CRUD == "insert")
				{
					// başarısız yeni kayıt mesajı 
					result = tablename + " tablosuna kaydedilemedi. HATA. ";

				}
				else if (CRUD == "update")
				{
					// başarısız güncelleme mesajı 
					result = tablename + " tablosundan güncellenemedi. HATA. ";

				}
				else if (CRUD == "delete")
				{
					// başarısız silme mesajı
					result = tablename + " tablosundan silinemedi. HATA. ";


				}
				else
				{
					// yanlış parametreler girildi (insert, update, delete)
					result = tablename + " tablosu için catch içinden yanlış " + CRUD + " parametresi";

				}
			}
			return result;
		}

		public static string liste_secim_yapilamadi = "Listeden seçim yapmadınız";


	}
}
