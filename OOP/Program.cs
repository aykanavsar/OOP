using OOP;

public class Program
{
    public static void Main(string[] args)
    {
        /*Robot robot = new Robot();
        //robot.name = "robot 1";
        //robot.batteryLevel = 98;
        //robot.model = "K3";


        //robot.PerformTask("task1");

        // hero, monster
        
        GameCharcter hero = new GameCharcter();
        hero.name = "Hero";
        hero.health = 100;
        hero.strenght = 20;
        hero.level = 1;

        GameCharcter monster = new GameCharcter();
        monster.name = "Monster";
        monster.health = 80;
        monster.strenght = 15;
        monster.level = 1;


        hero.Attack(monster);
        monster.Attack(hero);

        hero.Heal(10);

        hero.LevelUp();
        hero.Attack(monster);
        */

        CoffeMachine machine = new CoffeMachine();

        machine.Model = "Barista Pro";
        machine.WaterLevel = 500;
        machine.cekirdek = 100;

        machine.Makecoffe();

        machine.AddWater(400);
        machine.Addcekirdek(100);


        for (int i = 0; i < 3; i++)
        {
            machine.Makecoffe();
        }

    }
}
       



