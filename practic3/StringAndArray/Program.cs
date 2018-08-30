using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double bufDouble;
            int bufInt;
            Money money = new Money(10,2000);

            Console.WriteLine("Введите номинал");
            double.TryParse(Console.ReadLine(),out bufDouble);
            money.SetNominalValue(bufDouble);

            Console.WriteLine("Введите номинал");
            int.TryParse(Console.ReadLine(), out bufInt);
            money.SetCount(bufInt);

            Console.WriteLine($"\n Ваш баланс: {money.AmountOfMoney()}");

            

            Console.WriteLine($"хватает ли вам на новый дом за 12тг: {money.WillYouHaveEnoughMoney(12)}");

            Console.ReadLine();
        }
    }
}
