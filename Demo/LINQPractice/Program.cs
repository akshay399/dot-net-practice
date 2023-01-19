using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            list.Add("monday");
            list.Add("tuesday");
            list.Add("wednesay");
            list.Add("thurday");
            list.Add("friday");
            var result = from days in list
                         where days.Contains("monday")
                         select new { days};
            foreach(var day in result)
            {
                Console.WriteLine(day);
            }

        }
    }
}
