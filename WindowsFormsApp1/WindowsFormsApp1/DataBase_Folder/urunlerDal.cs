using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ZtashiaCompanyForm.DataBase_Folder
{
    public class urunlerDal
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        bool result;

        public bool Add(string uAdi, string aMarka, string aModel, string pNo, int adet)
        {
            sql = "INSERT INTO dbo.Urunler (uAdi,aMarka,aModel,pNo,adet) VALUES ('" + uAdi + "', '" + aMarka + "', '" + aModel + "', '" + pNo + "', '" + adet + "');";
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

        public bool Update(int uID,string uAdi,string aMarka,string aModel,string pNo,int adet)
        {
            sql = "UPDATE dbo.Urunler SET uAdi='" + uAdi + "',aMarka='" + aMarka + "',aModel='" + aModel + "',pNo='" + pNo + "',adet='" + adet + "' WHERE uID=" + uID;
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

        public bool AdetAzaltArttir(int uID,int adet)
        {
            sql = "UPDATE dbo.Urunler SET adet='"+adet+"' WHERE uID=" + uID;
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

    }
}
