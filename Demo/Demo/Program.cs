using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arithmetic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("hello");
            Console.WriteLine("Enter x value");
            string xVal = Console.ReadLine();
            int x = Convert.ToInt32(xVal);
            Console.WriteLine("Enter y value");
            
            
            string yVal = Console.ReadLine();
            int y = Convert.ToInt32(yVal);
            Maths obj = new Maths();
            int res = obj.Add(x,y);
            Console.WriteLine("The addition is: " + res);
            Console.ReadLine();

        }
    }
}
