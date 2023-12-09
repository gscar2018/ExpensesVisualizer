namespace ExpensesVisualizer
{
    public partial class LogIn : Form
    {
        private string userName;
        private string password;

        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set the username and password from sign up
            userName = SignUp.instance.UserName;
            password = SignUp.instance.Password;
        }
        private void button1_Click(object sender, EventArgs e)

        {
            // check if user name and password are empty
            if (userName == null && password == null)
                MessageBox.Show("You have not signed up yet");

            //check if the username and password match varibles from sign up
            else if (txtUserName.Text == userName && txtPassword.Text == password)
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // if username and password are empty display a message box with information
            if (userName == null && password == null)
                MessageBox.Show("You have not signed up yet");
            // if user forgot password and username display a message box with information
            else
            MessageBox.Show("For the this class i'll show the username and password here when you forget: \n Username: " + userName + "\n Password: " + password);

        }
    }
}
