using System;
using CSharp_Annotations.Annotations.CustomAttribute;
using CSharp_Annotations.Annotations.LoggingMethodExecutionTime;
using CSharp_Annotations.Annotations.MarkAttributeImportant;
using CSharp_Annotations.Annotations.MaxLengthAttribute;
using CSharp_Annotations.Annotations.MethodsOverride;
using CSharp_Annotations.Annotations.RoleBasedAccessControl;
using CSharp_Annotations.Annotations.SupressWarnings;
using CSharp_Annotations.Annotations.TodoAttributeForPending;
using CSharp_Annotations.Annotations.UseObseluteAttribute;

namespace CSharp_Annotations.Annotations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ExecuteMethodOverride.Execute();

            // ExecuteObselute.Execute();

            // SupressWarningExecute.Execute();

            // ExecuteTask.Execute();

            // ExecuteImportantMethod.Execute();

            // ExecuteTodoTask.Execute();

            // ExecuteLogging.Execute();

            // try
            // {
            //     User user1 = new User("Rishabh");   // Valid
            //     user1.Display();

            //     User user2 = new User("VeryLongUsername"); // this should give error message.
            //     user2.Display();
            // }
            // catch (ArgumentException ex)
            // {
            //     Console.WriteLine("Validation Error: " + ex.Message);
            // }

            RoleMain.Execute();
        }
    }
}