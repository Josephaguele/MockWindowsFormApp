using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User : IEquatable<User>    
    {
        // declaring setters and getters for variables
        public  string Email { get; set; }
        public  string Password { get; set; }


        // Making a constructor for the User class so the email and password can be accessed from anywhere the class is called
        public User(string email, string password) {
            Email = email;
            Password = password;
        }

        // Method for making sure that the .Contains Method of the list of users works as expected.
        // This compares the User in the list with the user that is being passed in when the the user signs in
        // if  the User details during sign in matches what is found in the list of users, the users is then 
        // granted access to the system
        public bool Equals(User? other)
        {
            if (this.Email == other.Email && this.Password == other.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
