using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public delegate void Buy();
    internal class BuyOnWildberrys
    {
        public void Buy()
        {
            Console.WriteLine("You made your order");
        }
        public void BuyAccept()
        {
            Console.WriteLine("Your order accepted");
        }
        public void Delivery1() 
        {
            Console.WriteLine("Your order is on the way");
        }
        public void YourCountry()
        {
            Console.WriteLine("Your order is in your country");
        }
        public void Delivery2() 
        {
            Console.WriteLine("Your order is on the way to point of issue");
        }
        public void Delivered()
        { 
            Console.WriteLine("Your order waits you"); 
            }
    }
}
