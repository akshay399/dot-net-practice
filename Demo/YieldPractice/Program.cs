using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            //foreach(string s in week){
            //    Console.WriteLine(s);
            //}

            //----
            //BTS-->
            IEnumerator i = week.GetEnumerator();
            while(i.MoveNext())
            {
                Console.WriteLine(i.Current);
            }
            Console.ReadLine();
        }

        //public static IEnumerable<int> GenerateFibonacci(int n) { 
        //    for(int i = 1, j=0,k=1; i <= n; i++)
        //    {
        //        yield return j;
        //        int temp = j + k;
        //        j = k;
        //        k = temp;
        //    }
        //}
    }

    class Week : IEnumerable {
        private string[] days =  { "monday", "tuesday", "wednesday", "thursday" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }
}
