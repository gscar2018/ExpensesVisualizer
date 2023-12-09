using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesVisualizer
{
    public partial class SignUp : Form
    {
        private string userName;
        private string password;
        private string confirmPassword;

        // create and instance of sign up
        public static SignUp instance = new SignUp();
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get the username and password from the text boxes
            SignUp.instance.userName = txtUserName.Text;
            SignUp.instance.password = txtPassword.Text;
            SignUp.instance.confirmPassword = txtConfirmPassword.Text;

            // check if the password and confirm password match
            if (SignUp.instance.password == SignUp.instance.confirmPassword)
            {
                // show the login form
                new LogIn().Show();
                this.Hide();
            }
            else
            {
                // display an error message
                MessageBox.Show("Passwords do not match");
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            // show the login form
            new LogIn().Show();
            this.Hide();
        }

        // getters and settees for the username and password
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }

        }

    }
}
