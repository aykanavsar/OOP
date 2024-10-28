using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class BaseGeometrikSekil
    {
        public int genislik {  get; set; }
        public int yukseklik { get; set; }
        public string sekil { get; set; }
        


        public void Print()
        {
            Console.WriteLine($"Genişlik : {genislik}\nYükseklik : {yukseklik}\nOlan {sekil} Alanı : {AlanHesapla()}");
        }

        public virtual double AlanHesapla()
        {
            return genislik * yukseklik;
        }

    }

    public class Kare : BaseGeometrikSekil
    {
        public Kare()
        {
            sekil = "Kare";
        }
    }
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen()
        {
            sekil = "Dikdörtgen";
        }
    }

    public class Ucgen : BaseGeometrikSekil
    {
        public Ucgen()
        {
            sekil = "Üçgen";
        }

        public override double AlanHesapla()
        {
            return base.AlanHesapla() / 2;
        }
    }




}
