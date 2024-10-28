using Inhertiance;
using System.ComponentModel;

public class program
{
    public static void Main(string[] args)
    {
        ogrenci ogrenci1 = new ogrenci();

        ogrenci1.Ad = "Aykan";
        ogrenci1.Soyad = "Avşar";
        ogrenci1.OgrenciNo = "158";


        ogretmen ogretmen1 = new ogretmen();

        ogretmen1.Ad = "Ali";
        ogretmen1.Soyad = "Avşar";
        ogretmen1.Maas = 1500;

        ogrenci1.OgrenciBilgi();
        ogretmen1.OgretmenBilgi();

    }
}