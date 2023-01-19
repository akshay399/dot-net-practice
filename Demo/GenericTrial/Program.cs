using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTrial
{
    class GenericCompare<T> where T: IComparable {
        public T data;
        public string process(T val) { 
            if(data.CompareTo(val) == 0)
            {
                return "Equal";
            }
            else
            {
                return "Not Equal";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericCompare<string> gcString = new GenericCompare<string>();
            gcString.data = "process";
            Console.WriteLine(gcString.process("process"));
            GenericCompare<int> gcInt = new GenericCompare<int>();
            gcInt.data = 2;
            Console.WriteLine(gcInt.process(2));
        }
    }
}
