using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _15DemoDisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Table 1 Created in Memory - HardCoded Data
            DataTable table = new DataTable("Emp");

            DataColumn column1 = new DataColumn("No", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Address", typeof(string));
            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column1 };

            DataRow row1 = table.NewRow();
            row1[0] = 1;
            row1[1] = "akshay";
            row1[2] = "pune";

            DataRow row2 = table.NewRow();
            row2[0] = 2;
            row2[1] = "john";
            row2[2] = "ny";

            table.Rows.Add(row1);
            table.Rows.Add(row2);
            #endregion
            #region Table 2 in Memory - Data is Database Table "Test"
            DataTable table2 = new DataTable("Test");
            DataColumn c1 = new DataColumn("TestNo", typeof(int));
            DataColumn c2 = new DataColumn("TestName", typeof(string));
            table2.Columns.Add(c1);
            table2.Columns.Add(c2);
            table2.PrimaryKey = new DataColumn[] { c1 };
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=punedb;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand command = new SqlCommand("select * from Test", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                DataRow row = table2.NewRow();
                row[0] = Convert.ToInt32(reader[0]);
                row[1] = reader[1].ToString();
                table2.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            #endregion
            #region dataset holding many tables
            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            ds.Tables.Add(table2);
            ds.WriteXml("C:\\DotNetLog\\XmlOfTableAndTable1");
            ds.WriteXmlSchema("C:\\DotNetLog\\SchemaOfTables");


            #endregion
        }
    }
}
