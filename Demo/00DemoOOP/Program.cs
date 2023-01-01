using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sql, 2. Oracle");
            int choice = Convert.ToInt32(Console.ReadLine());
            DatabaseInstance databaseInstance = new DatabaseInstance();
            
            Database iDatabase = databaseInstance.GetMyDatabaseInstance(choice);
            Database LoggerDatabase = new LoggerDatabase(iDatabase);
            LoggerDatabase.Insert();
        }
    }
    public class LoggerDatabase : Database
    {
        private Database db;
        private Logger logger = Logger.GetLoggerInstance();
        public LoggerDatabase(Database dbType) { 
            this.db = dbType;
        }
        public void Delete()
        {
            db.Insert();
            logger.Log("Logger: Insert done.");
        }

        public void Insert()
        {

            db.Insert();
            logger.Log("Logger: Update done.");
        }

        public void Update()
        {

            db.Insert();
            logger.Log("Logger: Delete done.");
        }
    }


    public class Logger {
        private static Logger _logger = new Logger(); 
        private Logger() { 
            
        }
        public static Logger GetLoggerInstance() { 
            return _logger;
        }

        public void Log(string msg) { 
            Console.WriteLine(msg);
        }
    }
    public interface Database {
        void Insert();
        void Update();
        void Delete();


    }
    public class SqlServer : Database {

        public   void Insert() {
            Console.WriteLine("SQL insert");
        }
        public   void Update()
        {
            Console.WriteLine("SQL update"); 
        }
        public   void Delete()
        {
            Console.WriteLine("SQL delete");
        }

        
    }

    public class OracleServer : Database {
        public   void Insert()
        {
            Console.WriteLine("Oracle insert");
        }
        public   void Update()
        {
            Console.WriteLine("Oracle update");
        }
        public   void Delete()
        {
            Console.WriteLine("Oracle delete");
        }
    }

    public class DatabaseInstance
    {
        public Database GetMyDatabaseInstance(int choice)
        {
            if (choice == 1)
            {
                return new SqlServer();
            }
            else return new OracleServer();
        }
    }
}
