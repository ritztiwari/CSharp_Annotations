using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharp_Annotations.Annotations.MaxLengthAttribute
{
    public class User
    {
        [MaxLength(10)]
        private string Username;

        public User(string username)
        {
            Type type = typeof(User);
            FieldInfo field = type.GetField("Username", BindingFlags.NonPublic | BindingFlags.Instance);

            MaxLengthAttribute attr = (MaxLengthAttribute)Attribute.GetCustomAttribute(field, typeof(MaxLengthAttribute));

            if (attr != null && username.Length > attr.value)
            {
                throw new ArgumentException($"Username cannot exceed {attr.value} characters.");
            }

            Username = username;
        }

        public void Display()
        {
            Console.WriteLine($"Username: {Username}");
        }
    }
}