using System;

namespace CSharp_Annotations.Annotations.TodoAttributeForPending
{
    public class ImplementTodo
    {
        [TodoTask("to do software development", "rishabh", "high")]
        public void First()
        {
            System.Console.WriteLine("Done 1");
        }

        [TodoTask("to do software development", "hardik", "high")]
        public void Second()
        {
            System.Console.WriteLine("Done 2");
        }

        public void Third()
        {
            System.Console.WriteLine("Done 3");
        }
    }
}