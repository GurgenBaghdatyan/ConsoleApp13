using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class A
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;              // 1.Определение события
        public A(int sum) => Sum = sum;
        public int Sum = 50;
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }

    public delegate int MoneyDelegate(int a);
    internal class MoneyCalculator
    {
        public int Car( int  a) => a + 50;
        public int Bar( int a) => a + 30;
        public int House( int a) => a + 100;
        public int Club( int a) => a + 10; 
    }
}
