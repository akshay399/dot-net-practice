using _14DemoLayered.DAL;
using _14DemoLayered.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _14DemoLayered
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpDataAccess dalObject = new EmpDataAccess();
            //Emp emp = new Emp();
            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //emp.Address = Console.ReadLine();
            //int rowsAffected = dalObject.AddEmployee(emp);
            //Console.WriteLine(rowsAffected);
            List<Emp> employees = dalObject.GetAllEmployees();
            foreach (Emp e in employees)
            {
                Console.WriteLine(e.Name);
            }

            //Console.WriteLine("Enter id of employee to delete");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Rows affected = " + dalObject.RemoveEmployee(id));
            
            Emp emp = new Emp();
            Console.WriteLine("Enter id of employee to update");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            emp.Address = Console.ReadLine();
            int rowsAffected = dalObject.UpdateEmployeeDetails(emp, id);
            Console.WriteLine("----------");
            List<Emp> employees2 = dalObject.GetAllEmployees();
            foreach (Emp e in employees2)
            {
                Console.WriteLine(e.Name);
            }
        }
    }
}
