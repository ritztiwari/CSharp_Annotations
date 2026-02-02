using System;

namespace CSharp_Annotations.Annotations.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TaskInfoAttribute : Attribute
    {
        public int priority { get; set; }
        public string assignedInfo { get; set; }

        public TaskInfoAttribute(int priority, string assignedInfo)
        {
            this.priority = priority;
            this.assignedInfo = assignedInfo;
        }
    }
}