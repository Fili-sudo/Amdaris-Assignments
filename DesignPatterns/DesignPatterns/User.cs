using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public enum Role { Admin, Regular }
    public class User : Entity
    {
        public string UserName { get; set; }
        public string Pass { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public User() { }
        public User(string userName, string pass, Role role)
        {
            UserName = userName;
            Pass = pass;
            Role = role;
        }
        public User(string userName, string pass, Role role, string firstName,
                    string lastName, string mail, string phone, string address)
        {
            UserName = userName;
            Pass = pass;
            Role = role;
            FirstName = firstName;
            LastName = lastName;
            Mail = mail;
            Phone = phone;
            Address = address;
        }


    }
}
