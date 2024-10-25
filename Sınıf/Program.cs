using System;

public class Person
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    public Person(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturma
        Person ogrenci1 = new Person("Ali", "Yılmaz", new DateTime(2005, 5, 15));
        Person ogrenci2 = new Person("Ayşe", "Kara", new DateTime(2006, 3, 20));

        // Öğretmen nesneleri oluşturma
        Person ogretmen1 = new Person("Mehmet", "Demir", new DateTime(1980, 7, 10));
        Person ogretmen2 = new Person("Fatma", "Çelik", new DateTime(1985, 11, 5));

        // Bilgileri konsola yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci1.BilgileriYazdir();
        ogrenci2.BilgileriYazdir();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen1.BilgileriYazdir();
        ogretmen2.BilgileriYazdir();
    }
}
Açıklama:
Person sınıfı, adı, soyadı ve doğum tarihini saklamak için gerekli property'lere sahip.
BilgileriYazdir metodu, kişinin bilgilerini konsola yazdırmak için kullanılıyor.
Main metodunda, iki öğrenci ve iki öğretmen nesnesi oluşturuluyor ve bilgileri yazdırılıyor.
Bu kodu çalıştırarak öğrencilerin ve öğretmenlerin bilgilerini konsolda görebilirsiniz!



Şunu dedin:
bunu c # yazarmısın
ChatGPT:
ChatGPT
Elbette! İşte yukarıda bahsettiğim sınıf yapısını C# dilinde yazılmış hali:

csharp
Kodu kopyala
using System;

public class Person
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    public Person(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturma
        Person ogrenci1 = new Person("Ali", "Yılmaz", new DateTime(2005, 5, 15));
        Person ogrenci2 = new Person("Ayşe", "Kara", new DateTime(2006, 3, 20));

        // Öğretmen nesneleri oluşturma
        Person ogretmen1 = new Person("Mehmet", "Demir", new DateTime(1980, 7, 10));
        Person ogretmen2 = new Person("Fatma", "Çelik", new DateTime(1985, 11, 5));

        // Bilgileri konsola yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci1.BilgileriYazdir();
        ogrenci2.BilgileriYazdir();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen1.BilgileriYazdir();
        ogretmen2.BilgileriYazdir();
    }
}