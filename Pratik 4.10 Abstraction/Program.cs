using Pratik_4._10_Abstraction;
using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        YazilimGelistirici Dev1 = new YazilimGelistirici("Aykan", "Avsar");
        Dev1.Gorev();

        ProjeYoneticisi py1 = new ProjeYoneticisi("Mahmut", "Tuncel");
        py1.Gorev();

        SatisDanismani st1 = new SatisDanismani("Ahmet", "Akar");
        st1.Gorev();
        

        
        Console.ReadKey();
    }
    
}
