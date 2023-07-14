using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate void MyDelegate();
    public delegate void KeyPressDelegate();
    public class MyClass
    {
        public event MyDelegate MyEvent = null;
        public void IvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
    public class Keyboard
    {
        public event KeyPressDelegate wKeyPressEvent = null;
        public event KeyPressDelegate sKeyPressEvent = null;
        public void WKeyPressEvent()
        {
            if(wKeyPressEvent != null) wKeyPressEvent.Invoke();
        }
        public void SKeyPressEvent()
        {
            if(sKeyPressEvent!= null) sKeyPressEvent.Invoke();
        }
    }
    
    internal class Program
    {
        static private void buttonW_Click()
        {
            Console.WriteLine("Go streight");
        }
        static private void buttonS_Click()
        {
            Console.WriteLine("Go back");
        }
        

        static private void Handler1()
        {
            Console.WriteLine("Event 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Event 2");
        }
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();
            
            keyboard.wKeyPressEvent += buttonW_Click;
            keyboard.sKeyPressEvent += buttonS_Click;
            
            
            ConsoleKey key;
            while(true)
            {
                key=Console.ReadKey().Key;
                switch(key)
                {
                    case ConsoleKey.W:
                        keyboard.WKeyPressEvent();
                        break;
                    case ConsoleKey.S:
                        keyboard.SKeyPressEvent();
                        break;
                }
            }
            MyClass myClass = new MyClass();
            myClass.MyEvent += Handler1;
            myClass.MyEvent += Handler2;
            myClass.IvokeEvent();
            Console.WriteLine("....");
            myClass.MyEvent -= Handler2;
            myClass.IvokeEvent();
            Console.ReadKey();
        }
    }

}
