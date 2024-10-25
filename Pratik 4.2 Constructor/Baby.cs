using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_4._2_Constructor
{
    internal class Baby
    {
        public string _name;
        public string _surname;
        public DateTime _birth;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
            public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }

        }
        public DateTime Birth
        {
            get
            {
                return _birth;
            }

            set
            {
                _birth = value;
            }
        }

        public Baby()
        {
            _birth = DateTime.Now;
            FirstCry();
        }

        public Baby(string name, string surname)
        {
            _name =name;
            _surname = surname;
            _birth = DateTime.Now;
            FirstCry();
        }

        public void Info()
        {
            Console.WriteLine($"Hoşgeldin {_name} Bebek ");
            Console.WriteLine($"Adı : {_name}\nSoyadı : {_surname}\nDoğum Tarihi : {_birth}");
        }

        public void FirstCry()
        {
            Console.WriteLine("Ingaaaaaaa");
        }

    
            

    
    }
}
