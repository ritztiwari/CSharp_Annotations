using System;
using System.Reflection;

namespace CSharp_Annotations.Annotations.MarkAttributeImportant
{
    public class ExecuteImportantMethod
    {
        public static void Execute()
        {
            Type type = typeof(MethodImplementation);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo item in methods)
            {
                ImportantTaskAttribute attr = (ImportantTaskAttribute)Attribute.GetCustomAttribute(
                    item, typeof(ImportantTaskAttribute));

                if (attr != null)
                {
                    Console.WriteLine($"Important Method Found: {item.Name}");
                    Console.WriteLine($"Importance Level: {attr.Level}");
                    Console.WriteLine();
                }
            }

        }
    }
}