using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZtashiaCompanyForm.DataBase_Folder
{
    public class DataBase
    {
        public static string GetConnectionString
        {
            get { return "Data Source=.\\SQLEXPRESS;Initial Catalog=vt_cikmayedekparca;Integrated Security=True"; }
        }
    }
}
