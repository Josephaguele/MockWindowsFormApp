using System.DirectoryServices;

namespace WinFormsApp1
{
    public partial class Signup : Form
    {
        
        public Signup()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();
        Thread thread;


        // This method was supposed to do the user password encryption, but I can't take it on due to time
        private string passwordEncrypterMethod(string password)
        {
            TextBox passwordTextBox = new TextBox();
            passwordTextBox.PasswordChar = '*';
            return password;
        }


        // Here the signup for the user is handled
        private void signUpButton_Click(object sender, EventArgs e)
        {
            string userEmail = emailTextBox.Text;
            string password = passwordTextBox.Text;
            User thisUser = new User(userEmail, password);

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password");
            }
            else if (password.Length < 10)
            {
                MessageBox.Show("Your password cannot be less than eight characters");
            }
            else if (users.Contains(thisUser))
            {
                MessageBox.Show("This user already exist in the system");
            }
            else
            {
                users.Add(new User(userEmail, password));
                Close();
                thread = new Thread(openWelcomePage);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                MessageBox.Show("Congratulations! You have signed up");
                // WelcomePage welcomePage = new WelcomePage();
                //welcomePage.ShowDialog();
            }
        }

        // Best way to handle windows form closure and tranistioning to a new one.
        private void openWelcomePage(object obj)
        {
            Application.Run(new WelcomePage());
        }


        private void openLogInPage(object? obj)
        {
            Application.Run(new Login());
        }

        private void navigateToLoginPageButton_Click(object sender, EventArgs e)
        {
            Close();
            thread = new Thread(openLogInPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        
    }
}
