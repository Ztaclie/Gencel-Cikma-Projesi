using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZtashiaCompanyForm.Kutuphane
{
    public class Gider
    {
        public int gID { get; set; }
        public string giderAdi { get; set; }
        public float giderMiktar { get; set; }

        public string giderTarih { get; set; }
        public string giderTur { get; set; }

        public Gider()
        {

        }

        public Gider(int gID, string giderAdi, float giderMiktar, string giderTarih, string giderTur)
        {
            this.gID = gID;
            this.giderAdi = giderAdi;
            this.giderMiktar = giderMiktar;
            this.giderTarih = giderTarih;
            this.giderTur = giderTur;
        }
    }
}
