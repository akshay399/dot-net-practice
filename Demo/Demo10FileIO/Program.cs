using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Demo10FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple File Writing
            //string logFilePath = ConfigurationManager.AppSettings["logFilePath"];
            //FileStream fs = new FileStream(logFilePath, FileMode.Truncate, FileAccess.Write);
            //StreamWriter writer= new StreamWriter(fs);
            //writer.WriteLine("Hello World2");
            //writer.Close();
            //fs.Close();
            #endregion

            #region Simple File Reading
            //string logFilePath = ConfigurationManager.AppSettings["logFilePath"];
            //FileStream fs = new FileStream(logFilePath, FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(fs);
            //string output = "";
            //int i = 0;
            //while (i != -1) {
            //    output += (char)i;
            //    i = reader.Read();
            //}
            //reader.Close();
            //fs.Close();
            //Console.WriteLine(output.TrimStart((char)0));
            #endregion

            #region Simple Object Writing / Serialization
            //Emp emp = null;
            //List<Emp> list = new List<Emp>();
            //while (true) { 
            //    Console.WriteLine("Enter No: ");
            //    int no = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Name: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter Address: ");
            //    string address = Console.ReadLine();
            //    emp = new Emp(no, name, address);
            //    list.Add(emp);
            //    Console.WriteLine("Do you want to continue? y / n");
            //    string choice =  Console.ReadLine();
            //    if (choice != "y") {
            //        break;
            //    }
            //}
            //foreach (Emp e in list) {
            //    Console.WriteLine(e.Name);
            //}

            //string logFilePath = ConfigurationManager.AppSettings["logFilePath"];
            //FileStream fs = new FileStream(logFilePath, FileMode.Create, FileAccess.Write);
            ////since it is an object that we are writing, we need a special pen(writer) which writes binary contents to a file.
            ////StreamWriter writer = new StreamWriter(fs);
            //BinaryFormatter specialWriter = new BinaryFormatter();
            //specialWriter.Serialize(fs, list);

            //specialWriter = null;
            //fs.Close();
            //Console.ReadLine();
            #endregion

            #region Simple Object reading / Deserialization
            //FileStream fsRead = new FileStream(logFilePath, FileMode.Open, FileAccess.Read);
            //BinaryFormatter specialReader = new BinaryFormatter();
            //Emp empRead = (Emp) specialReader.Deserialize(fsRead);
            //Console.WriteLine("No: {0}, Name = {1},Address = {2}", empRead.No, empRead.Name, empRead.Address); 
            //Console.ReadLine();
            #endregion

            #region Simple LIST reading / Deserialization
            string logFilePath = ConfigurationManager.AppSettings["logFilePath"];
            FileStream fs = new FileStream(logFilePath, FileMode.Open, FileAccess.Read);
            BinaryFormatter reader = new BinaryFormatter();
            List<Emp> list = (List<Emp>) reader.Deserialize(fs);
            foreach (Emp e in list)
            {
                Console.WriteLine(e.Name + e.No + e.Address);
            }
            #endregion  
        }
    }

    [Serializable]
    public class Emp {
        private int _No;
        private string _Name;
        private string _Address;
        [NonSerialized]
        private string _Password = "abcad@1234";
        public Emp(int _No, string _Name, string _Address) { 
            this.No = _No;
            this.Name= _Name;
            this.Address= _Address;
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
