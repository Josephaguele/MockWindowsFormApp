using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            // Here the form components are being initialized
            InitializeComponent();
        }

        // Here I am assuming that the list of users inputted during the sign up have been added to the system.
        // A typical scenario will need a database but this is just done for testing purposes
        List<User> users = new List<User> { new User("joe@gmail.com", "1234567890") };
       

        Thread thread;

        // This method handles the user sign in process.
        private void signInButton_Click(object sender, EventArgs e)
        {
            // get userInput from the email text box
            string userEmail = emailTextBox.Text;
            // get user input from the password text box
            string password = passwordTextBox.Text;

            // pass in the user details  so it can be checked for in the list of users exisiting in the system
            User thisUser = new User(userEmail, password);

            // if the useremailbox or password emailbox is empty then show this message below
            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password");
            }
            else if (users.Contains(thisUser))// if the usersList contains the user that is trying to login, grant them access
            {
                // close the current windows
                Close();
                // open the welcome page
                thread = new Thread(openWelcomePage);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                MessageBox.Show("Access granted");
            }else { MessageBox.Show("You do not have access to this system. Kindly login to gain access"); }
        }

        // This is the best way I found to Run a new window in stackoverflow after much research.
        private void openWelcomePage(object obj)
        {
            Application.Run(new WelcomePage());
        }

    }
}
