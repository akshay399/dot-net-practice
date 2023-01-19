using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void MyDelegate();
    class NumberAdder {
        public event MyDelegate myEvent;
        private int m, n;
        public NumberAdder(int m, int n) {
            this.m = m;
            this.n = n;
        }
        public int Add() {
            int sum = m + n;
            if (sum % 2 != 0) {
                myEvent();
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            NumberAdder adder = new NumberAdder(2, 8);
            adder.myEvent += HandleOddEvent;
            Console.WriteLine("Sum of the number is: " + adder.Add());
        }
        static void HandleOddEvent() {
            Console.WriteLine("Odd number detected!!!");
        }
    }
}
