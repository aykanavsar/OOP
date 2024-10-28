using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_4._10_Abstraction
{
    public abstract  class Sirket
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        

        public Sirket(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
           

        }

        public abstract void Gorev();

    }

    public class YazilimGelistirici : Sirket
    {
        public YazilimGelistirici(string ad, string soyad) : base(ad, soyad)
        {
            
        }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} Görevi Yazılım Gelistirici.");
        }
    }

    public class ProjeYoneticisi : Sirket
    {
        public ProjeYoneticisi(string ad, string soyad) : base(ad, soyad)
        {

        }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} Görevi Proje Yöneticisi.");
        }
    }

    public class SatisDanismani : Sirket
    {
        public SatisDanismani(string ad, string soyad) : base(ad, soyad)
        {

        }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} Görevi Satış Danışmanı.");
        }
    }
}
