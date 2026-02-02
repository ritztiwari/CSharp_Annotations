using System;

namespace CSharp_Annotations.Annotations.RoleBasedAccessControl
{
    public class User
    {
        public string Name { get; }
        public string Role { get; }
        public User(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}