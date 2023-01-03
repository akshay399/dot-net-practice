using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace _13DemoDBProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string details = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            Console.WriteLine(details);
            #region select query
            ////1.create connection and open connection.
            //SqlConnection con = new SqlConnection(details);
            //con.Open();
            ////3.create a command(this is like prepared statement.)
            //SqlCommand command = new SqlCommand("SELECT * FROM EMP", con);
            ////4.execute the command statement. (sqldatareader is like resultSet)
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString() + " " + reader["name"].ToString() + " " + " " +
            //                        reader["address"].ToString());

            //}
            //reader.Close();
            //con.Close();
            #endregion

            #region insert query
            //SqlConnection con = new SqlConnection(details);
            //con.Open();
            //Console.WriteLine("Enter No");
            //int No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //string Address = Console.ReadLine();

            //string queryFormat = "insert into Emp values({0}, '{1}', '{2}')";
            //string query = string.Format(queryFormat, No, Name, Address);

            //SqlCommand command = new SqlCommand(query, con);

            //int countOfRowsAffected = command.ExecuteNonQuery();

            //Console.WriteLine("Rows Affected = {0}", countOfRowsAffected);
            #endregion
            #region Update Query
            //SqlConnection connection = new SqlConnection(details);

            //connection.Open();

            //Console.WriteLine("Enter No");
            //int No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //string Address = Console.ReadLine();

            //string queryFormat = "update Emp set Name='{1}', Address='{2}' where No = {0}";
            //string query = string.Format(queryFormat, No, Name, Address);

            //SqlCommand command = new SqlCommand(query, connection);

            //int countOfRowsAffected = command.ExecuteNonQuery();

            //Console.WriteLine("Rows Affected = {0}", countOfRowsAffected);

            //connection.Close();
            #endregion

            #region Delete Query
            SqlConnection connection = new SqlConnection(details);

            connection.Open();

            Console.WriteLine("Enter No");
            int No = Convert.ToInt32(Console.ReadLine());

            string queryFormat = "delete from Emp where No = {0}";
            string query = string.Format(queryFormat, No);

            SqlCommand command = new SqlCommand(query, connection);

            int countOfRowsAffected = command.ExecuteNonQuery();

            Console.WriteLine("Rows Affected = {0}", countOfRowsAffected);

            connection.Close();
            #endregion
        }
    }
}
