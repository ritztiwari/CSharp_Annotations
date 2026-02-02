using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace CSharp_Annotations.Annotations.SupressWarnings
{
    public class SupressWarningExecute
    {
        public static void Execute()
        {
#pragma warning disable CS0618
#pragma warning disable CS8600
#pragma warning disable CS8602
            ArrayList list = new ArrayList();

            list.Add(10);        // int (boxed)
            list.Add("Hello");   // string
            list.Add(3.14);      // double (boxed)

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}