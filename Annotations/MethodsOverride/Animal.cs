using System;

namespace CSharp_Annotations.Annotations.MethodsOverride
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Sound");
        }
    }
}