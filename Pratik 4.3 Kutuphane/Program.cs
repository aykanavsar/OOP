using Pratik_4._3_Kutuphane;

internal class Program
{
    private static void Main(string[] args)
    {
        kitap kitap1 = new kitap();
        kitap1.BookName = "Adı Aylin";
        kitap1.ArtName = "Ayşe";
        kitap1.ArtSurname = "Kulin";
        kitap1.PageCount = "398";
        kitap1.Publisher = "Remzi Kitapevi";

        kitap1.Info();

    }
}