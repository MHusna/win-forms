using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOtomasyon
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public int Maas { get; set; }
        public Boolean Durum { get; set; }
        public string Meslek { get; set; }

        public Personel(int id, string ad, string soyad, string sehir, int maas, bool durum, string meslek)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Sehir = sehir;
            Maas = maas;
            Durum = durum;
            Meslek = meslek;
        }
    }
}
