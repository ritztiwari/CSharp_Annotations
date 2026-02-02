using System;

namespace CSharp_Annotations.Annotations.MarkAttributeImportant
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ImportantTaskAttribute : Attribute
    {
        public string Level { get; }

        // Optional parameter with default value
        public ImportantTaskAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
}