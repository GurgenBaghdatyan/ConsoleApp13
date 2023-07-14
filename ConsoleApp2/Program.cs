using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class Boozer
        {
            public int BoozerAmount { get; set; }
            public event EventHandler OilEnded;
            public Boozer()
            {
                BoozerAmount = 100;
            }
            private void Worker()
            {
                for(int i=BoozerAmount; i>=5; i--)
                {
                    if(BoozerAmount == 0) 
                    {
                        if(OilEnded!=null)
                        {
                            OilEnded(this, new EventArgs());
                        }
                    }
                }
            }
            
        }
        class Gopnic
        {
            public int SemkiAmount { get; set; }
            public event EventHandler OilEnded;
            public void Gopnik()
            { SemkiAmount = 250; }
        }
        static void Main(string[] args)
        {
            var boozer= new Boozer();
            
            var gopnik = new Gopnic();

        }
    }
}
