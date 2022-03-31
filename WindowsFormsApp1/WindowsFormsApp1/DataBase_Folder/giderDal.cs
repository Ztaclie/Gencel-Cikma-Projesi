using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZtashiaCompanyForm.DataBase_Folder
{
    public class giderDal
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        bool result;

        public bool Add(string gAdi, float gMiktar, string gTarih, string gTur)
        {
            sql = "INSERT INTO dbo.Gider (gAdi,gMiktar,gTarih,gTur) VALUES ('" + gAdi + "', '" + gMiktar + "', '" + gTarih + "', '" + gTur + "');";
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

        public bool Update(int gID, string gAdi, float gMiktar, string gTarih, string gTur)
        {
            sql = "UPDATE dbo.Gider SET gAdi='" + gAdi + "',gMiktar='" + gMiktar + "',gTarih='" + gTarih + "',gTur='" + gTur + "' WHERE gID=" + gID;
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
