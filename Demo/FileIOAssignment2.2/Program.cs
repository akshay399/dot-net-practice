using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAssignment2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = ConfigurationManager.AppSettings["logFilePath"];
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryFormatter reader = new BinaryFormatter();
            Emp emp = (Emp)reader.Deserialize(fs);
            Console.WriteLine(emp.No +  emp.Name +  emp.Address);
            Console.WriteLine("Reading done...");


        }
    }
    [Serializable]
    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;
        public Emp(int _No, string _Name, string _Address)
        {
            this.No = _No;
            this.Name = _Name;
            this.Address = _Address;
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }



    }
}
