using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;


namespace CSharp_Annotations.Annotations.TodoAttributeForPending
{
    public class ExecuteTodoTask
    {
        public static void Execute()
        {
            Type type = typeof(ImplementTodo);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo method in methods)
            {
                TodoTaskAttribute attr = (TodoTaskAttribute)Attribute.GetCustomAttribute(method, typeof(TodoTaskAttribute));

                if (attr != null)
                {
                    Console.WriteLine($"Important Method Found: {attr.task}");
                    Console.WriteLine($"Assigned To: {attr.assignedTo}");
                    Console.WriteLine($"Importance Level: {attr.priority}");
                }
            }
        }
    }
}