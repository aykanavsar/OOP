using OOP;

public class Program
{
    public static void Main(string[] args)
    {
        

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




