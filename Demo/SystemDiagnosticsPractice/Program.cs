using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace SystemDiagnosticsPractice
{
    delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            #region normal method call
            //watch.Start();
            //bool res = Check(10);
            //watch.Stop();
            //Console.WriteLine(res);
            //Console.WriteLine(watch.ElapsedTicks); //580
            #endregion

            #region calling using delegate
            //MyDelegate pointer = Check;
            #endregion

            #region calling using anonymous method concept
            //MyDelegate pointer = delegate (int x)
            //{
            //    return x > 10;
            //};
            #endregion

            #region calling using lambda expression
            //MyDelegate pointer = x => x > 10;
            #endregion
            #region call lambda expression using func delegate
            Func<int,  bool> pointer =  x =>x> 10 ;
            //now the above happens
            #endregion
            #region checking result
            watch.Start();
            bool result = pointer(20);
            watch.Stop();
            #endregion
            #region
            Console.WriteLine("Result is {0}", result);
            Console.WriteLine("Time Taken = {0} Ticks",
            watch.ElapsedTicks);
            #endregion
            #region Func and Action delegate trials
            //Func<int, int> f1Pointer = x => RandomValue(x);
            //Console.WriteLine( f1Pointer(20));
            //Action<int, int> actionPointer = (x, y) => Console.WriteLine(x+y);
            //actionPointer(10, 20);
            #endregion
        }

        public static bool Check(int x) {
            return x > 10;
        }
        public static int RandomValue(int x) {
            Console.WriteLine("in random value");
            return x * 10;
        }
    }
}
