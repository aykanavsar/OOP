using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CoffeMachine
    {
        private string model;
        private int Waterlevel;
        private int_cekirdek;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int WaterLevel
        {
            get
            {
                return Waterlevel;
            }
            set
            {
                if (value >= 0)
                {
                    Waterlevel = value;
                }
            }
        }

        public int cekirdek
        {
            get
            {
                return cekirdek;
            }
            set
            {
                if (value >= 0)
                {
                    cekirdek = value;
                }
            }
        } 
        
        public void Makecoffe()
        {
            if (Waterlevel >= 200 && cekirdek >= 15)
            {
                Console.WriteLine("Kahve Hazır");
                cekirdek -= 15;
                Waterlevel -= 200;

            }

            else
            {
                Console.WriteLine("Yeterli su veya kahve yok");
            }
        }

        public void AddWater(int amount)
        {
            if (amount > 0)
            {
                Waterlevel += amount;
                Console.WriteLine($"{amount} ml su eklendi. Güncel su seviyesi {Waterlevel} ml");
            }
        }

        public void Addcekirdek(int amount)
        {

            if (amount > 0)
            {
                cekirdek += amount;
                Console.WriteLine($"{amount} ml kave çekirdeği eklendi. Güncel kahve miktarı {cekirdek} gram");
            }
        }
    }

    
}
