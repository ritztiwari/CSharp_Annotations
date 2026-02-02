using System;

namespace CSharp_Annotations.Annotations.LoggingMethodExecutionTime
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogAttribute : Attribute
    {
        public string Name { get; set; }

        public LogAttribute(string name)
        {
            Name = name;
        }
    }
}