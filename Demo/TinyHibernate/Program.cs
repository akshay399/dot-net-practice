using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunbeamAnnotations;
using POCOLib;
using System.Reflection;
using System.Diagnostics;

namespace TinyHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Users\caksh\Desktop\my-git-class-lab-internal\dotnet-git\Demo\POCOLib\bin\Debug\POCOLib.dll";
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type[] allTypes = assembly.GetTypes();
            foreach (Type type in allTypes) {
                string details = "";
                IEnumerable<Attribute> allAttributesOnType = type.GetCustomAttributes();
                foreach(Attribute attribute in allAttributesOnType)
                {
                    if (attribute is Table) {
                        Table tableDetails = (Table)attribute;
                        details = details+ "CREATE TABLE " + tableDetails.Name + " (";
                        break;
                    }
                }
                PropertyInfo[] allProperties = type.GetProperties();
                foreach (PropertyInfo property in allProperties)
                {
                    IEnumerable<Attribute> allAttributesOnProperty = property.GetCustomAttributes();
                    foreach(Attribute attribute in allAttributesOnProperty) { 
                        if(attribute is Column)
                        {
                            Column columnDetails = (Column)attribute;
                            details = details + columnDetails.Name + " " + columnDetails.Type + ",";
                            break;
                        }
                    }
                }
                details = details.TrimEnd(',');
                details =details+ ")";
                Console.WriteLine(details);
            }
        }
    }
}
