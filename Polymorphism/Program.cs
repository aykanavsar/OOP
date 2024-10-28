using Polymorphism;

public class Program
{
    public static void Main(string[] args)
    {
        Kare kare = new Kare();
        kare.yukseklik = 4;
        kare.genislik = 4;

        Dikdortgen diktorgen = new Dikdortgen();    
        diktorgen.genislik = 8;
        diktorgen.yukseklik = 2;

        Ucgen ucgen = new Ucgen();
        ucgen.genislik = 9;
        ucgen.yukseklik = 2;

        kare.Print();
        diktorgen.Print();
        ucgen.Print();
    }
};