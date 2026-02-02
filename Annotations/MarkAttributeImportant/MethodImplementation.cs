using System;

namespace CSharp_Annotations.Annotations.MarkAttributeImportant
{
    public class MethodImplementation
    {
        [ImportantTask]
        public void ProcessPayment()
        {
            System.Console.WriteLine("processing payments");
        }

        [ImportantTask("CRITICAL")]
        public void ShutdownSystem()
        {
            Console.WriteLine("System shutting down!");
        }

        public void HelperMethod()
        {
            Console.WriteLine("This is not marked important.");
        }
    }
}