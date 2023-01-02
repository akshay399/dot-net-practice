using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteInFile();
            ArrayList  listObject = ReadFromFile();
            PrintFromFile(listObject);
        }

        public static void PrintFromFile(ArrayList listObject) {
            Console.WriteLine(listObject);
            foreach (object obj in listObject)
            {
                if (obj is Emp)
                {
                    Emp e = (Emp)obj;
                    Console.WriteLine("Emp: {0}, {1}, {2}", e.No, e.Name, e.Address);
                }
                else if (obj is Book)
                {
                    Book b = (Book)obj;
                    Console.WriteLine("Book: {0}, {1}", b.ISBN, b.Title);
                }
            }
        }
        public static void WriteInFile() {
            string logFilePath = ConfigurationManager.AppSettings["logFilePath"];
            ArrayList list = new ArrayList();
            #region Writing in log file serialization
            if (File.Exists(logFilePath)) {
                ArrayList addedObjects = ReadFromFile();
                list.AddRange(addedObjects);
            }
            Emp emp = null;
            Book book = null;
            
            while (true)
            {
                Console.WriteLine("Select which object you want to add: 1.Employee, 2.Book");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("You chose employee---");
                    Console.WriteLine("Enter emp no");
                    int no = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter emp name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter emp address");
                    string address = Console.ReadLine();
                    emp = new Emp(no, name, address);
                    list.Add(emp);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose Book---");
                    Console.WriteLine("Enter ISBN");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Title");
                    string title = Console.ReadLine();
                    book = new Book(isbn, title);
                    list.Add(book);
                }
                Console.WriteLine("Do you want to continue? y / n");
                string ip = Console.ReadLine().ToLower();
                if (ip != "y")
                {
                    break;
                }
            }

            FileStream fs = new FileStream(logFilePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter writer = new BinaryFormatter();
            writer.Serialize(fs, list);
            writer = null;
            fs.Close();

            #endregion

        }

        public static ArrayList ReadFromFile() {

            string logFilePath = ConfigurationManager.AppSettings["logFilePath"];
            #region reading from log file 

            FileStream fsRead = new FileStream(logFilePath, FileMode.Open, FileAccess.Read);
            BinaryFormatter reader = new BinaryFormatter();
            ArrayList listObject = (ArrayList) reader.Deserialize(fsRead);
            
            reader = null;
            fsRead.Close();
            return listObject;
            #endregion
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

    [Serializable]
    public class Book
    {
        private int _ISBN;
        private string _Title;

        public Book(int iSBN, string title)
        {
            this.ISBN = iSBN;
            this.Title = title;
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

    }
}
