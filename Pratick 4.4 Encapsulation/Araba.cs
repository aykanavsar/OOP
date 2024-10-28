using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_4._4_Encapsulation
{
    internal class Araba
    {
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapisayisi;

        

        public string Marka { get { return _marka; } }
        public string Model { get { return _model; } }

        public string Renk { get { return _renk; } }

        public int Kapisayisi
        {
            get { return _kapisayisi; }
            set
            {
                if ( value == 2 || value == 4 )
                {

                    Kapisayisi = value;

                }


                else
                {
                    Console.WriteLine("Kapıs sayısı sadece 2 ve ya 4 olabilir");
                    Kapisayisi = -1;
                }

            }
        }

        public Araba(string marka, string model, string renk, int kapisayisi)
        {
            _marka = marka;
            _model = model;
            _renk = renk;
            _kapisayisi = kapisayisi;

        }
        public void BilgileriGoster()
        {
            Console.WriteLine($"Marka : {_marka}");
            Console.WriteLine($"Model : {_model}");
            Console.WriteLine($"Renk : {_renk}");
            Console.WriteLine($"Kapı Sayısı : {Kapisayisi}");


        }





    }
}
