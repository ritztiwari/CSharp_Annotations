using System;

namespace CSharp_Annotations.Annotations.LoggingMethodExecutionTime
{
    public class LogImplent
    {
        [Log("rishabh")]
        public void First()
        {
            System.Console.WriteLine("done");
        }

        [Log("hardik")]
        public void Second()
        {
            System.Console.WriteLine("this is GLA University");
            System.Console.WriteLine("HOD");
        }
    }
}
