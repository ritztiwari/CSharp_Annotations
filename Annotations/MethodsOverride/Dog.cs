using System;

namespace CSharp_Annotations.Annotations.MethodsOverride
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog Barking");
        }
    }
}