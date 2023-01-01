using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2._3ABC
{
    public delegate void MyDelegate();
    public class A {
        public void m1(MyDelegate d1) {
            d1();
            Console.WriteLine("m1 in A");
        }
    }
    public class B
    {
        public void m2()
        {
            Console.WriteLine("m2 in B");
        }
    }
    public class C
    {
        public void m3()
        {
            Console.WriteLine("m3 in C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a  = new A();
            B b  = new B();
            C c = new C();
            MyDelegate bPointer = new MyDelegate(b.m2);
            bPointer += c.m3;
            a.m1(bPointer);
            Console.ReadLine();
        }
    }
}
