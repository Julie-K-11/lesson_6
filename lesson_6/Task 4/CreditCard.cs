using lesson_6.Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6.Task_4
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVC { get; set; }
        public int Balance { get; set; }

        public void InputData()
        {
            Console.Write("Введіть номер картки: ");
            CardNumber = Console.ReadLine();
            Console.Write("Введіть термін дії картки: ");
            ExpirationDate = Console.ReadLine();
            Console.Write("Введіть CVC код: ");
            CVC = Console.ReadLine();
            Console.Write("Введіть баланс картки: ");
            Balance = int.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine($"Номер картки: {CardNumber}");
            Console.WriteLine($"Термін дії картки: {ExpirationDate}");
            Console.WriteLine($"CVC код: {CVC}");
            Console.WriteLine($"Баланс картки: {Balance}");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Баланс картки: {Balance}");
        }

        public static CreditCard operator +(CreditCard card, int amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, int amount)
        {
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVC != card2.CVC;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard other)
            {
                return this.CVC == other.CVC;
            }
            return false;
        }
    }
}
