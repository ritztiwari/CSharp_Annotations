using System;
using System.Reflection;

namespace CSharp_Annotations.Annotations.CustomAttribute
{
    public class ExecuteTask
    {
        public static void Execute()
        {
            Type type = typeof(TaskManager);

            MethodInfo method = type.GetMethod("CompleteTask");

            TaskInfoAttribute attr = (TaskInfoAttribute)Attribute.GetCustomAttribute(
                method,
                typeof(TaskInfoAttribute));

            if (attr != null)
            {
                Console.WriteLine($"Priority: {attr.priority}");
                Console.WriteLine($"Assigned To: {attr.assignedInfo}");
            }
            else
            {
                Console.WriteLine("TaskInfo attribute not found.");
            }


        }
    }
}