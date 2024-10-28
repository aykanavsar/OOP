using Pratik_4._4_Encapsulation;

public class Program
{
    public static void Main(string[] args)
    {
        Bankaccount bankaccount = new Bankaccount("Murat", 100, "djasdafafafa");

        bankaccount.DisplayBalance();

        bankaccount.Deposit(500);

        bankaccount.Withdraw(400);

        bankaccount.DisplayBalance();

        bankaccount.Withdraw(500);

    }

}