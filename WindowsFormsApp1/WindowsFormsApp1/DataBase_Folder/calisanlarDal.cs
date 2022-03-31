using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ZtashiaCompanyForm.DataBase_Folder
{
    public class calisanlarDal
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        bool result;

        public bool Add(string nickname, string sifre, string kullaniciAdi, string kullaniciSoyadi, string kullaniciTel, string kullaniciRol)
        {
            sql = "INSERT INTO dbo.Calisanlar (kAdi,sifre,ad,soyad,telefon,rol) VALUES ('" + nickname + "', '" + sifre + "', '" + kullaniciAdi + "', '" + kullaniciSoyadi + "', '" + kullaniciTel + "', '" + kullaniciRol + "');";
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
        //
        public bool Update(int kID,string nickname, string sifre, string kullaniciAdi, string kullaniciSoyadi, string kullaniciTel, string kullaniciRol)
        {
            sql = "UPDATE dbo.Calisanlar SET kAdi='" + nickname + "',sifre='" + sifre + "',ad='" + kullaniciAdi + "',soyad='" + kullaniciSoyadi + "',telefon='" + kullaniciTel + "',rol='" + kullaniciRol + "' WHERE kID=" + kID;
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {

                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}
