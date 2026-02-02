using System;

namespace CSharp_Annotations.Annotations.TodoAttributeForPending
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TodoTaskAttribute : Attribute
    {
        public string task { get; set; }
        public string assignedTo { get; set; }

        public string priority { get; set; }

        public TodoTaskAttribute(string task, string assignedTo, string priority = "Medium")
        {
            this.task = task;
            this.assignedTo = assignedTo;
            this.priority = priority;
        }
    }
}