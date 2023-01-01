using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEventDelegateDatabase
{
    public delegate void LoggerDelegate(string dbType);
    class Program
    {
        static void Main(string[] args)
        {
            MySQL sql = new MySQL();
            Oracle or = new Oracle();
            or.OnInsertHandler+=Logger.GetLogger().InsertLog;
            or.InsertInDB();

        }

    }

    public class Logger {
        private static Logger logger = new Logger();
        private Logger() { }
        public static Logger GetLogger() {
            return logger;
        }
        public void InsertLog(string dbType) {
            Console.WriteLine("Inserted into {0} database successfully!", dbType);
        }
        public void UpdateLog(string dbType)
        {
            Console.WriteLine("Updated in {0} database successfully!", dbType);
        }
    }

    public abstract class Database {
        abstract protected void Insert();
        abstract protected void Update();
        public event LoggerDelegate OnInsertHandler;
        
        public void InsertInDB() { 
            Insert();
            OnInsertHandler(this.GetType().Name);
        }
        public void UpdateDB() {
            Update();
        }
    }

    public class MySQL : Database{
        
        protected override void Insert() {
            Console.WriteLine("SQL insert called");
            
        }

        protected override void Update()
        {
            Console.WriteLine("SQL Update called");

        }
    }
    public class Oracle : Database
    {
        protected override void Insert()
        {
            Console.WriteLine("Oracle insert called");

        }
        protected override void Update()
        {
            Console.WriteLine("Oracle Update called");

        }
    }
}
