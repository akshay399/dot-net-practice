using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2._2MulticastDelegate
{
    public delegate int MyDelegate(int x, int y);
   class Program
    {
        public static int Add(int x, int y) { 
            Console.WriteLine(x + y);
            return 1;
        }
        public static int Multiply(int x, int y) {
            Console.WriteLine(x * y);
            return 1;
        }
        static void Main(string[] args)
        {
            MyDelegate pointer = Program.Add;
            pointer += Program.Multiply;
            pointer(10, 20);
        }
    }
}
