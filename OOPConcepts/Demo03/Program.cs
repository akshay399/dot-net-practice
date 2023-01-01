using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log1 = Logger.getInstance();
            Logger log2 = Logger.getInstance();
            if(log1.Equals(log2))
            {
                Console.WriteLine("same instance!!!");
            }
        }
    }
    public class Logger {
        private static Logger logger = null;
        private Logger() {

        }

        public static Logger getInstance() { 
            if(logger == null) { 
                logger = new Logger();
            }

            return logger;
        }

    }
}
