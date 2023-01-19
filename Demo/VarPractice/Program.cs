using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = 10;
            var s2 = "string";
            string s3 = null;
            s2 = s3;
            var s4 = s3;
            var emp = new { Name = "akshay", No = 1 };
            var emp1 = new { Name = "akshay", No = 1 };
            var emp2 = new { Name = 2, No = "ronit"};
            var emp3 = new { No = 3, Name = "saurabh" };
            Console.WriteLine(emp.GetType() + " \n" + emp2.GetType() + " \n" + emp3.GetType());
            Console.WriteLine("---object---");
            object obj1 = new { Name = "obj1", Id = 1 };
            object obj2 = new { Name = 1, Id = "2" };
            Console.WriteLine(obj1.GetType() + " " + obj2.GetType());
            emp = emp1;
        }
    }
}
