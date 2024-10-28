using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertiance
{
    internal class ogretmen : Kisi
    {
        public decimal Maas { get; set; }
        public void OgretmenBilgi()
        {
            AdSoyad();
            Console.WriteLine($"Maas: {Maas}");
            
            
        }
    }
}
