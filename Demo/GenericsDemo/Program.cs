using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calling generic class having normal method 
            //Maths<int> maths= new Maths<int>();
            //int p = 10;
            //int q = 20;
            //string before = string.Format("Before swapping: p = {0}, q = {1} ", p, q);
            //maths.Swap(ref p, ref q);
            //string after = string.Format("After swapping: p = {0}, q = {1}", p, q);
            //Console.WriteLine(before + after);
            //Maths<string> strMaths = new Maths<string>();
            //string str1 = "hi";
            //string str2 = "hello";
            //string strBefore = string.Format("Before string swapping: a = {0}, b={1}", str1, str2);
            //strMaths.Swap(ref str1, ref str2);
            //string strAfter = string.Format("Before string swapping: a = {0}, b={1}", str1, str2);
            //Console.WriteLine();
            //Console.WriteLine(strBefore + strAfter);
            #endregion

            #region Calling normal method and generic method in a non generic class
            Maths maths = new Maths();
            int p = 10;
            int q = 20;
            string before = string.Format("Before swapping: p = {0}, q = {1} ", p, q);
            maths.Swap(ref p, ref q);
            string after = string.Format("After swapping: p = {0}, q = {1}", p, q);
            Console.WriteLine(before + after);
            Console.WriteLine();
            maths.SayHi();
            #endregion
        }
    }

    #region Generic class with normal method
    //class Maths<T> { 
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T temp = x;
    //        x = y;
    //        y = temp;
    //    }
    //}
    #endregion
    #region
    class Maths {
        public void SayHi() {
            Console.WriteLine("Hi mom!");
        }

        public void Swap<T>(ref T x, ref T y) { 
            T temp = x;
            x = y;
            y = temp;

        }
    }
    #endregion
}
