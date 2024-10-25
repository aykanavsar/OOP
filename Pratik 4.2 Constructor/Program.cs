using Pratik_4._2_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {
        Baby Bebek1 = new Baby();

        Bebek1.Name = "Ahmet Ege";
        Bebek1.Surname = "Avşar";
        Bebek1.Info();

        Console.WriteLine(new string('-', 30));

        Baby Bebek2 = new Baby();
        Bebek2.Info();



        Console.ReadKey();

    }
}