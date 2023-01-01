using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Demo2._1EventsDelegates
{
    public delegate void MyDelegate(string result);
    class Program
    {
        static void Main(string[] args)
        { 
            MyDelegate pointer = new MyDelegate(CodeDependentOfHeavyLogicReturnedValue);
            A a = new A();
            a.HeavyLogic(pointer);
            Console.WriteLine("Independent code that should be executed without waiting for heavy logic to finish");
            Console.ReadLine();
        }

        public static void CodeDependentOfHeavyLogicReturnedValue(string result) {
            Console.WriteLine("in CodeDependentOfHeavyLogicReturnedValue");
            Console.WriteLine(result); 
        }
    }

    public class A {
        public void HeavyLogic(MyDelegate pointer) {
            System.Threading.Thread.Sleep(3000);
            //await Task.Delay(3000);
            Console.WriteLine("I will be shown after 3000 ms");
            string res = "This is the data which is result of heavy logic.";
            pointer(res);
        }
    }
}
