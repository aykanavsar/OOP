using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertiance
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad {  get; set; }  
        public void AdSoyad()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }
}
