using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16DemoDisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            string details = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=punedb;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(details);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from emp", connection);
            da.Fill(ds);
        }
    }
}
