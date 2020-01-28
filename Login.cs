using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyHub
{
    public partial class Login : Form
    {
        #region Login
        #region Startup
        public Login()
        {
            InitializeComponent();
        }
        #endregion
        #region initialize variables
        //Variables
        User currentUser = null;
        User testUser = new User("test", "test");
        Home application = new Home();
        String userText = string.Empty;
        String pwdText = string.Empty;
        #endregion
        #region User Attempts to Login 
        private void loginButton_Click(object sender, EventArgs e)
        {
            userText = this.usernameText.Text;
            pwdText = this.passwordText.Text;
            if (!userText.Equals(string.Empty) && !pwdText.Equals(string.Empty))
            {
                this.credentialsInvalidText.Visible = false;
                //TODO: Check the userText against the database to see if there is an 
                //      account with that user name and then check the password if there is.
                //for now the code will check to see if the user is test and password is test.
                if (userText.Equals("test"))
                {
                    if (pwdText.Equals("test"))
                    {
                        Console.WriteLine(DateTime.Now + ": Login Succeeded, User: " + testUser.getUsername());
                        application.Show();
                        this.Hide();
                    }
                    else
                    {
                        Console.WriteLine(DateTime.Now + ": Login Credentials Invalid:");
                        this.credentialsInvalidText.Visible = true;
                    }
                }
                else
                {
                    Console.WriteLine(DateTime.Now + ": Login Credentials Invalid:");
                    this.credentialsInvalidText.Visible = true;
                }
            }
            else
            {
                Console.WriteLine(DateTime.Now + ": Login Credentials Invalid:");
                this.credentialsInvalidText.Visible = true;
            }
        }
        #endregion

        #endregion
    }
}
