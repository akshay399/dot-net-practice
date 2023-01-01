using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EventsAndDelegates
{
    delegate bool MyDelegate(int x);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate pointer1 = new MyDelegate(Check);
     
            bool result = pointer1(91);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }

        public static bool Check(int x) {
            return x > 10;
        }
    }
}
