using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DemoFeatures
{
    #region Partial class
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(10, 20);
            math.Add();
        }
    }
    sealed public partial class Math
    {
        private int x;
        private int y;

        public Math(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //public partial void Subtract();
    }

    public partial class Math
    {
        public void Add()
        {
            Console.WriteLine(this.x + this.y);
        }
        //public partial void Subtract()
        //{
        //    Console.WriteLine(x-y);
        //}
    }
    #endregion

    #region Nullable types
    //class Program { 
    //    static void Main(string[] args)
    //    {
    //        int i = 10;
    //        //i = null; gives error as int i is a value type and it cant hold null
    //        //hence we will convert int to a nullable type so it can hold its underlying values as well as null.
    //        int? j = 10; //? makes it nullable, BTS it is using Nullable<T>
    //        Nullable<int> k = null;

    //        //conversion of nullable type to simple underlying value type
    //        //converting j, we will need some value inorder to represent null for new value type, hence use non coaleasing operator '??'
    //        int a = k ?? -1;
    //        Console.WriteLine("a: " + a);
    //    }
    //}
    #endregion


    #region Anonymous mehtods
    //class Program {
    //delegate void ArithmeticOps(int x, int y);    //class Program {
    //delegate void ArithmeticOps(int x, int y);
        #region without anonymous methods
        //static void Add(int x, int y)
        //{
        //    Console.WriteLine("Addition: {0}" , x+y);
        //}
        //static void Subtract(int x, int y)
        //{
        //    Console.WriteLine("Subtraction: {0}" , x - y);
        //}
        //static void Main(string[] args)
        //{
        //    ArithmeticOps operations = Add;
        //    operations += Subtract;
        //    operations(10, 200);
        //}
        #endregion

        #region using anonymous methods
        //static void Main(string[] args)
        //{
        //    ArithmeticOps add = delegate (int x, int y)
        //    {
        //        Console.WriteLine(x + y);
        //    };
        //    add += delegate (int x, int y)
        //    {
        //        Console.WriteLine(x - y);
        //    };
        //    add(10, 20);
        //}
        #endregion

        #region using lambda expression
        //static void Main(string[] args) { 
        
        //    ArithmeticOps add = (int x, int y) => {
        //        Console.WriteLine(x + y);
        //        };
        //    add(10,20);
        //}
        #endregion
   // }
    #endregion
}
