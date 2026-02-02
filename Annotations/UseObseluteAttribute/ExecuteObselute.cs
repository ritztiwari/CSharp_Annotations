using System;

namespace CSharp_Annotations.Annotations.UseObseluteAttribute
{
    public class ExecuteObselute
    {
        public static void Execute()
        {
            LegacyAPI api = new LegacyAPI();

            System.Console.WriteLine("old feature");
            api.Print();

            System.Console.WriteLine("new feature");
            api.NewMethod();
        }
    }
}