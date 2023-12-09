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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if there is a instance of expenses display an error message
            if (Expenses.instance != null)
            {
                MessageBox.Show("You can edit the info you inputed in Edit Expenses");
            }else
            {
                new Expenses().Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // if there is not an instance of expenses display an error message
            if (Expenses.instance == null)
            {
                MessageBox.Show("You must enter expenses before you can view them");
            }
            else
            {
                new PieChartGenerator().Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // if there is not an instance of expenses display an error message
            if (Expenses.instance == null)
            {
                MessageBox.Show("You must enter expenses before you can edit them");
            }
            else
            {
                new editExpenses().Show();
                this.Hide();
            }

        }
    }
}
