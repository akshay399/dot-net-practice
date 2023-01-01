using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            string result = a.HeavyLogic();
            Console.WriteLine(result);  
            Console.WriteLine("I am completely independent of A object's HeavyLogic method");
            Console.ReadLine();
        }
    }

    public class A {
        public string HeavyLogic() {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Hi i will be executed after 5000 ms");
            return "I am returned from HeavyLogic.";
        }
    }
}
