using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTrial
{
    internal interface IMath1
    {
        void Add();
    }
    internal interface IMath2
    {
        //void Subtract();
        void Add();
    }
    internal class Math1 : IMath1, IMath2 {
         void IMath1.Add() {
            Console.WriteLine("Add from IMath1 in Math1");
        }
         void IMath2.Add()
        {
            Console.WriteLine("Add from IMath2 in Math1");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMath1 iMath = new Math1();
            iMath.Add();
        }
    }
}
