using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuyOnWildberrys buy = new BuyOnWildberrys();
            Buy buy1 = new Buy(buy.Buy);
            buy1 += buy.BuyAccept;
            buy1 += buy.Delivery1;
            buy1 += buy.YourCountry;
            buy1 += buy.Delivery2;
            buy1 += buy.Delivered;
            buy1();
            MoneyCalculator moneyCalculator = new MoneyCalculator();
            MoneyDelegate money = new MoneyDelegate(moneyCalculator.Car);
            Console.WriteLine(money(50));





            A a = new A(20);
            void DisplayMessage(string message) => Console.WriteLine(message);
            void DisplayRedMessage(string message)
            {
                // Устанавливаем красный цвет символов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                // Сбрасываем настройки цвета
                Console.ResetColor();
            }

            a.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
            a.Notify += DisplayRedMessage;    // добавляем обработчик DisplayRedMessage
            a.Put(20);    // добавляем на счет 20
            a.Notify -= DisplayRedMessage;     // удаляем обработчик DisplayRedMessage
            a.Put(50);
            a.Put(5);
            a.Take(500);
            Console.ReadKey();
        }
    }
}
