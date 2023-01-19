using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "abc@gmail.com";
            //Console.WriteLine(MyString.ValidateEmail(email));
            Console.WriteLine(email.ValidateEmail());
            

            //adding a double method to int class
            int x = 10;
            Console.WriteLine(x.Double());
        }
    }

    static class MyInt {
        public static int Double(this int i) {
            return i * 2;
        }
    }
    static class  MyString { 
        public static bool ValidateEmail<T>(this T email)
        {
            Console.WriteLine(email.GetType());
            string strEmail = Convert.ToString(email);

            return strEmail.Contains("@");

        }
    }
}
