using OOP2;

public class Program
{
    public static void Main(string[] args)
    {
        
        Product Laptop = new Product();
        Laptop.Name = "Laptop";
        Laptop.Price = 10000;
        Laptop.Stock = 10;

        Product phone = new Product();
        phone.Name = "Telefon";
        phone.Price = 3000;
        phone.Stock = 20;

        Laptop.DisplayProduct();
        phone.DisplayProduct();

        Laptop.SelProduct(2);
        phone.SelProduct(5);

        Laptop.RestockProduct(5);
        phone.RestockProduct(10);



    }
}




