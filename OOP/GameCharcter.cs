using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class GameCharcter
    {
        //özellik
        public string name;
        public int health;
        public int strenght;
        public int level;

        public void Attack(GameCharcter gameCharcter)
        {
            Console.WriteLine($"{name} adlı karakter {gameCharcter.name} adlı karaktere saldırdı.");
            gameCharcter.health -= strenght;
            Console.WriteLine($"{gameCharcter.name} adlı karakterin {gameCharcter.health} sağlık değeri kaldı");
        }

        public void Heal(int amount)
        {
            health += amount;
            Console.WriteLine($"{name} adlı karakterin toplam sağlık değeri {health} çıktı");

        }

        public void LevelUp()
        {
            level++;
            strenght += 10;
            Console.WriteLine($"{name}, {level} e atladı. Güç değeri {strenght}");

        }

    }
}
