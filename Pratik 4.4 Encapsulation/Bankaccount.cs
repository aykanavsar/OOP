using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_4._4_Encapsulation
{
    public class Bankaccount
    {
        private string _owner;
        private decimal _balance;
        private string _accountNumber;

        public Bankaccount(string owner, decimal initialBalance, string accountNumber)
        {
            _owner = owner;
            _balance = initialBalance;
            _accountNumber = accountNumber;


        }

        public string Owner
        {
            get { return _owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _owner = value;
                }

                else
                {
                    Console.WriteLine("Hesap Sahibi Adı Boş Geçilemez");
                }
            }
        }
public Bankaccount(string owner)
        {
            Owner = owner;
        }

        public decimal Balance
        {

            get { return _balance; }

        }

        public string AccounNumber
        {
            get { return _accountNumber; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Yatırlan tutar : {amount}\nGüncel bakiyeniz : {_balance} ");
            }

            else
            {
                Console.WriteLine("Yatırılan para sıfırdan büyük olmalıdır.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} para çekildi. Yeni bakiyeniz {_balance}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");

            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Hesap sahibi : {_owner}");
            Console.WriteLine($"Hesap numarası : {_accountNumber}");
            Console.WriteLine($"Mevcut bakiye: {_balance}");
        }

    }
}
    

