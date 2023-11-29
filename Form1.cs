namespace ExpensesVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)

        {
            if (txtUserName.Text =="joe" && txtPassword.Text== "password")
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
