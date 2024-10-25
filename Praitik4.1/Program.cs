using Praitik4._1;

public class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person();

        person1.Name = "Aykan";
        person1.Surname = "Avşar";
        person1.Birth = "10.02.1990";

        Person person2 = new Person();
        person2.Name = "Tuğba";
        person2.Surname = "Avşar";
        person2.Birth = "15.03.1994";

        person1.InformationWrite();
        person2.InformationWrite();
    }

}