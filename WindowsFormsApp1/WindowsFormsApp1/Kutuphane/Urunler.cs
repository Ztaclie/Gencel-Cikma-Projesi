using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZtashiaCompanyForm.Kutuphane
{
    public class Urunler
    {
        public int urunID { get; set; }

        public string urunAdi { get; set; }

        public string arabaMarka { get; set; }
        public string arabaModel { get; set; }
        public int parcaNo { get; set; }
        public int adet { get; set; }

        public Urunler()
        {

        }
        public Urunler(int urunID,string urunAdi,string arabaMarka,string arabaModel,int parcaNo,int adet)
        {
            this.urunID = urunID;
            this.urunAdi = urunAdi;
            this.arabaMarka = arabaMarka;
            this.arabaModel = arabaModel;
            this.parcaNo = parcaNo;
            this.adet = adet;
        }
    }
}
