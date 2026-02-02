using System;

namespace CSharp_Annotations.Annotations.MaxLengthAttribute
{
    [AttributeUsage(AttributeTargets.Field)]
    public class MaxLengthAttribute : Attribute
    {
        public int value;

        public MaxLengthAttribute(int value)
        {
            this.value = value;
        }
    }
}