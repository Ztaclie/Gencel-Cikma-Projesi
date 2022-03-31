using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZtashiaCompanyForm.Kutuphane
{
    public class calisanlar
    {
        public int kullaniciID { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }
        public string kullaniciTel { get; set; }
        public string KullaniciRol { get; set; }

        public calisanlar()
        {

        }

        public calisanlar(int kullaniciID, string nickname, string password, string kullaniciAdi, string kullaniciSoyadi, string kullaniciTel, string kullaniciRol)
        {
            this.kullaniciID = kullaniciID;
            this.nickname = nickname;
            this.password = password;
            this.kullaniciAdi = kullaniciAdi;
            this.kullaniciSoyadi = kullaniciSoyadi;
            this.kullaniciTel = kullaniciTel;
            this.KullaniciRol = KullaniciRol;
        }

    }
}
