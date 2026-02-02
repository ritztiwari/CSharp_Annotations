using System;

namespace CSharp_Annotations.Annotations.CustomAttribute
{

    public class TaskManager
    {
        [TaskInfo(1, "Rishabh")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed.");
        }
    }
}