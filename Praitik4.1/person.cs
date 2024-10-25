using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praitik4._1
{
    public class Person
    {
        private string name;
        private string surname;
        private string birth;
        private string status;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }

        }

        public string Birth
        {
            get
            {
                return birth;
            }

            set
            {
                birth = value;
            }
        }


        public void InformationWrite()
        {
            Console.WriteLine($"Adı: {name}\nSoyadı : {surname}\nDoğum Tarihi : {birth} ");
        }

    }


}

