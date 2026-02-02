using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace CSharp_Annotations.Annotations.LoggingMethodExecutionTime
{
    public class ExecuteLogging
    {
        public static void Execute()
        {
            Type type = typeof(LogImplent);

            object instance = Activator.CreateInstance(type);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo method in methods)
            {
                LogAttribute attr = (LogAttribute)Attribute.GetCustomAttribute(method, typeof(LogAttribute));

                if (attr != null)
                {
                    Console.WriteLine(attr.Name);

                    Stopwatch stopwatch = Stopwatch.StartNew();

                    method.Invoke(instance, null);

                    stopwatch.Stop();
                    Console.WriteLine($"Execution Time: {stopwatch.Elapsed}");
                    Console.WriteLine();
                }
            }
        }
    }
}