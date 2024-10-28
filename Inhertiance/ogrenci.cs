using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertiance
{
    public class ogrenci : Kisi
    {
        public string OgrenciNo { get; set; }   
        public void OgrenciBilgi()
        {
            AdSoyad();
            Console.WriteLine($"Numarası: {OgrenciNo}");
            
        }
    }
}
