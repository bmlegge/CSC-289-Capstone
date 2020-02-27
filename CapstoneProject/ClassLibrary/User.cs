using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Admin { get; set; }

        public User(string firstName, string lastName, string userName, string password, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
        }

        public User()
        {

        }
    }
}
