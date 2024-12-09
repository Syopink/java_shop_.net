using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class User
    {
        public string IdCustomer { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string NumberOfPhone { get; set; }

        // Constructor with email, fullName, and role
        public User(string email, string fullName, string role)
        {
            Email = email;
            FullName = fullName;
            Role = role;
        }

        // Constructor with all properties
        public User(string email, string fullName, string role, string address, string numberOfPhone, string idCustomer)
        {
            Email = email;
            FullName = fullName;
            Role = role;
            Address = address;
            NumberOfPhone = numberOfPhone;
            IdCustomer = idCustomer; // Set IdCustomer in the constructor
        }

        // Constructor with only email
        public User(string email)
        {
            Email = email;
        }

        // Default constructor
        public User()
        {
        }
    }
}
