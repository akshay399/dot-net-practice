using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Arithmetic;
namespace DemoReflection
{
    class Program
    {
        #region Reflection1
        //static void Main(string[] args)
        //{
        //    string pathOfAssembly = @"C:\Users\caksh\Desktop\my-git-class-lab-internal\dotnet-git\Demo\Arithmetic\bin\Debug\Arithmetic.dll";
        //    Assembly assembly = Assembly.LoadFrom(pathOfAssembly);
        //    Type[] allTypes = assembly.GetTypes();
        //    foreach (Type type in allTypes) {
        //        Console.WriteLine(type.FullName);
        //        MethodInfo[] methodInfos = type.GetMethods();
        //        foreach (MethodInfo method in methodInfos) {
        //            string details = "";
        //            details = details + method.ReturnType + " " + method.Name + "(" ;
        //            ParameterInfo[] parameterInfos = method.GetParameters();
        //            foreach (ParameterInfo parameterInfo in parameterInfos) {
        //                string paramDataType = parameterInfo.ParameterType.ToString();
        //                string paramName = parameterInfo.Name;
        //                details = details + paramDataType + " " + paramName + ","; 
        //            }
        //            details = details.TrimEnd(',');
        //            details = details +")";
        //            Console.WriteLine(details);
        //        }
        //        Console.WriteLine("-------------");
        //    }
        //}
        #endregion
        #region Reflection2
        static void Main(string[] args) {
            string pathOfAssembly = @"C:\Users\caksh\Desktop\my-git-class-lab-internal\dotnet-git\Demo\Arithmetic\bin\Debug\Arithmetic.dll";
            Assembly assembly = Assembly.LoadFrom(pathOfAssembly);
            Type[] allTypes = assembly.GetTypes();
            object dynamicObject = null;
            foreach (Type type in allTypes)
            {
                dynamicObject = assembly.CreateInstance(type.FullName);
                MethodInfo[] methodInfos = type.GetMethods();
                foreach(MethodInfo method in methodInfos) {
                    ParameterInfo[] parameterInfos = method.GetParameters();
                    object[] allParamValues = new object[parameterInfos.Length];
                    for (int i = 0; i < parameterInfos.Length; i++)
                    {
                        Console.WriteLine("Enter value for {0} of type {1}.", parameterInfos[i].Name, parameterInfos[i].ParameterType);
                        allParamValues[i] = Convert.ChangeType(Console.ReadLine(), parameterInfos[i].ParameterType);

                    }
                    object result = type.InvokeMember(method.Name,
                                                      BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                                                      null,
                                                      dynamicObject,
                                                      allParamValues);
                }
            }
        }
        #endregion
    }
}
