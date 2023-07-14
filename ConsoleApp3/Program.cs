using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example
{
    public delegate string demoDelegate(string str1, string str2);
    class MyEvents
    {
        event demoDelegate myEvent;
        public MyEvents()
        {
            this.myEvent += new demoDelegate(this.Display);
        }
        public string Display(string studentname, string subject)
        {
            return "Student: " + studentname + "\nSubject: " + subject;
        }
        static void Main(string[] args)
        {
            MyEvents e = new MyEvents();
            string res = e.myEvent("Jack", "Science");
            Console.WriteLine("RESULT...\n" + res);
            Console.ReadKey();
        }
    }
}


