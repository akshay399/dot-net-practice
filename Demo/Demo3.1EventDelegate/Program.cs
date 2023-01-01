using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3._1EventDelegate
{
    public delegate void Mediator();
    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "John";
            Mediator pointer1 = new Mediator(OnAccept);
            Mediator pointer2 = new Mediator(OnReject);
            student1.Accepted += pointer1;
            student1.Rejected += pointer2;
            //student1.Accepted+=
            student1.Propose("sunbeam");
        }

        public static void OnAccept()
        {
            Console.WriteLine("Accepted");
        }
        public static void OnReject() {
            Console.WriteLine("Rejected");
        }
    }

    public class Student {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public event Mediator Accepted;
        public event Mediator Rejected;

        public void Propose(string data) {
            if (data == "sunbeam")
            {
                Rejected();
            }
            else {
                Accepted();
            }    
    }

    }
}
