using _14DemoLayered.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14DemoLayered.DAL
{
    class EmpDataAccess
    {
        public List<Emp> GetAllEmployees() { 
            List<Emp> list = new List<Emp>();
            
            string details = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            SqlConnection con = new SqlConnection(details);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM EMP", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Emp e = new Emp();
                e.No = Convert.ToInt32(reader[0]);
                e.Name = reader["Name"].ToString(); 
                e.Address = reader["Address"].ToString();
                list.Add(e);
            }
            reader.Close();
            con.Close();
            return list;
        }

        public int AddEmployee(Emp emp) {
            int rowsAffected = -1;
            string details = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            SqlConnection con = new SqlConnection(details);
            con.Open();
            string queryFormat = "insert into Emp values({0}, '{1}', '{2}')";
            string query = string.Format(queryFormat, emp.No, emp.Name, emp.Address);

            SqlCommand command = new SqlCommand(query, con);
            rowsAffected = command.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public int RemoveEmployee(int id) {
            int rowsAffected = -1;
            string details = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            SqlConnection con = new SqlConnection(details);
            con.Open();
            string queryFormat = "delete from Emp where No={0}";
            string query = string.Format(queryFormat, id);
            SqlCommand command = new SqlCommand(query, con);
            rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }
        public int UpdateEmployeeDetails(Emp emp, int id) {
            string details = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            SqlConnection con = new SqlConnection(details);
            con.Open();
            string queryFormat = "update Emp set Name='{1}', Address = '{2}' where No={0}";
            string query = string.Format(queryFormat, id,emp.Name, emp.Address);
            SqlCommand command = new SqlCommand(query, con);
            return command.ExecuteNonQuery();
        }
    }
}

