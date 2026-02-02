using System;

namespace CSharp_Annotations.Annotations.UseObseluteAttribute
{
    public class LegacyAPI
    {
        [Obsolete]
        public void Print()
        {
            System.Console.WriteLine("printing old features");
        }

        public void NewMethod()
        {
            System.Console.WriteLine("this is new method");
        }
    }
}