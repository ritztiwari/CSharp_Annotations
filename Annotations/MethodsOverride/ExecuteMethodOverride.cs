using System;
using CSharp_Annotations.Annotations.MethodsOverride;

namespace CSharp_Annotations.Annotations.MethodsOverride
{
    public class ExecuteMethodOverride
    {
        public static void Execute()
        {
            Animal animal = new Dog();

            animal.MakeSound();
        }
    }
}