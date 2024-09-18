using Microsoft.AspNetCore.Identity;

namespace FlavourlinesWebApp.Models
{
    // Ensure the User class inherits from IdentityUser
    public class User : IdentityUser
    {
        // Additional custom properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // Default Constructor
        public User() : base() { }

        // Parameterized Constructor
        public User(string name, string lastName, string phone, string address)
        {
            Name = name;
            LastName = lastName;
            Phone = phone;
            Address = address;
        }
    }
}