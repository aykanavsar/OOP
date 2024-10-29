using System;

abstract class BaseMakine
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public BaseMakine()
    {
        UretimTarihi = DateTime.Now; 
    }

    public virtual void BilgileriYazdir()
    {
        Console.WriteLine("Üretim Tarihi: " + UretimTarihi);
        Console.WriteLine("Seri Numarası: " + SeriNumarasi);
        Console.WriteLine("Ad: " + Ad);
        Console.WriteLine("Açıklama: " + Aciklama);
        Console.WriteLine("İşletim Sistemi: " + IsletimSistemi);
    }

    public abstract void UrunAdiGetir();
}

class Telefon : BaseMakine
{
    public bool TrLisansli { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine("TR Lisanslı: " + (TrLisansli ? "Evet" : "Hayır"));
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine("Telefonunuzun adı ---> " + Ad);
    }
}

class Bilgisayar : BaseMakine
{
    private int _usbGirisSayisi;
    public int UsbGirisSayisi
    {
        get { return _usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _usbGirisSayisi = value;
            }
            else
            {
                Console.WriteLine("Geçersiz USB Giriş Sayısı! USB Giriş Sayısı -1 olarak atanıyor.");
                _usbGirisSayisi = -1;
            }
        }
    }
    public bool Bluetooth { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine("USB Giriş Sayısı: " + UsbGirisSayisi);
        Console.WriteLine("Bluetooth: " + (Bluetooth ? "Evet" : "Hayır"));
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine("Bilgisayarınızın adı ---> " + Ad);
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();
                UrunBilgileriniAl(telefon);
                Console.WriteLine("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "evet";

                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();
                UrunBilgileriniAl(bilgisayar);
                Console.WriteLine("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                Console.WriteLine("Bluetooth özelliği var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";

                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyiniz.");
                continue;
            }

            Console.WriteLine("Ürün başarıyla üretildi! Başka bir ürün üretmek ister misiniz? (Evet/Hayır): ");
            string devam = Console.ReadLine().ToLower();
            if (devam != "evet")
            {
                Console.WriteLine("İyi günler dileriz!");
                break;
            }
        }
    }

    static void UrunBilgileriniAl(BaseMakine urun)
    {
        Console.WriteLine("Seri Numarasını Giriniz: ");
        urun.SeriNumarasi = Console.ReadLine();

        Console.WriteLine("Adını Giriniz: ");
        urun.Ad = Console.ReadLine();

        Console.WriteLine("Açıklama Giriniz: ");
        urun.Aciklama = Console.ReadLine();

        Console.WriteLine("İşletim Sistemini Giriniz: ");
        urun.IsletimSistemi = Console.ReadLine();
    }
}
