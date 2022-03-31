using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZtashiaCompanyForm.Kutuphane
{
    public class Gelir
    {
        public int gID { get; set; }
        public string gelirAdi { get; set; }
        public float gelirMiktar { get; set; }

        public string gelirTarih { get; set; }
        public string gelirTur { get; set; }

        public Gelir()
        {

        }

        public Gelir(int gID,string gelirAdi,float gelirMiktar,string gelirTarih,string gelirTur)
        {
            this.gID = gID;
            this.gelirAdi = gelirAdi;
            this.gelirMiktar = gelirMiktar;
            this.gelirTarih = gelirTarih;
            this.gelirTur = gelirTur;
        }

    }
}
