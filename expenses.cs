using System;
using System.Collections;
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
    public partial class Expenses : Form
    {
        private double housePayments;
        private double carPayments;
        private double utilities;
        private double food;
        private double clothing;
        private double medicalInsurance;
        private double homeInsurance;
        private double carInsurance;
        private double entertainment;
        private double miscellaneous;

        // create an instance of the form
        public static Expenses instance;

        public Expenses()  
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // from the input, check if the user entered a valid number and not a string
            // if the user entered a string, clear the input and focus on the input
            // if the user entered a negative number, clear the input and focus on the input
            // if the user entered a valid number, set the variable to the input
            // if the user did not enter a number, set the variable to 0
            if (housePaymentsinput.Text == "" || !double.TryParse(housePaymentsinput.Text, out housePayments) || Convert.ToDouble(housePaymentsinput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for House Payments");
                housePaymentsinput.Clear();
                housePaymentsinput.Focus();
                return;
            }
            if (carPaymentsInput.Text == ""  || !double.TryParse(carPaymentsInput.Text, out carPayments) || Convert.ToDouble(carPaymentsInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Car Payments");
                carPaymentsInput.Clear();
                carPaymentsInput.Focus();
                return;
            }
            if (utilitiesInput.Text == ""  || !double.TryParse(utilitiesInput.Text, out carPayments) || Convert.ToDouble(utilitiesInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Utilities");
                utilitiesInput.Clear();
                utilitiesInput.Focus();
                return;
            }
            if (foodInput.Text == ""  || !double.TryParse(foodInput.Text, out carPayments) || Convert.ToDouble(foodInput.Text) < 0) 
            {
                MessageBox.Show("Please enter a valid number for Food");
                foodInput.Clear();
                foodInput.Focus();
                return;
            }
            if (clothingInput.Text == ""  || !double.TryParse(clothingInput.Text, out clothing) || Convert.ToDouble(clothingInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Clothing");
                clothingInput.Clear();
                clothingInput.Focus();
                return;
            }
            if (medicalInsurancelnput.Text == "" || !double.TryParse(medicalInsurancelnput.Text, out carPayments) || Convert.ToDouble(medicalInsurancelnput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Medical Insurance");
                medicalInsurancelnput.Clear();
                medicalInsurancelnput.Focus();
                return;
            }
            if (homeInsuranceInput.Text == "" || !double.TryParse(homeInsuranceInput.Text, out carPayments) || Convert.ToDouble(homeInsuranceInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Home Insurance");
                homeInsuranceInput.Clear();
                homeInsuranceInput.Focus();
                return;
            }
            if (carInsuranceInput.Text == "" || !double.TryParse(carInsuranceInput.Text, out carPayments) || Convert.ToDouble(carInsuranceInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Car Insurance");
                carInsuranceInput.Clear();
                carInsuranceInput.Focus();
                return;
            }
            if (entertanmentInput.Text == "" || !double.TryParse(entertanmentInput.Text, out carPayments) || Convert.ToDouble(entertanmentInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Entertainment");
                entertanmentInput.Clear();
                entertanmentInput.Focus();
                return;
            }
            if (miscellaneousInput.Text == "" || !double.TryParse(miscellaneousInput.Text, out carPayments) || Convert.ToDouble(miscellaneousInput.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number for Miscellaneous");
                miscellaneousInput.Clear();
                miscellaneousInput.Focus();
                return;
            }


            //check if the user entered a value for each expense
            Expenses.instance.housePayments = housePaymentsinput.Text == "" ? 0 : Convert.ToDouble(housePaymentsinput.Text);
            Expenses.instance.carPayments = carPaymentsInput.Text == "" ? 0 : Convert.ToDouble(carPaymentsInput.Text);
            Expenses.instance.utilities = utilitiesInput.Text == "" ? 0 : Convert.ToDouble(utilitiesInput.Text);
            Expenses.instance.food = foodInput.Text == "" ? 0 : Convert.ToDouble(foodInput.Text);
            Expenses.instance.clothing = clothingInput.Text == "" ? 0 : Convert.ToDouble(clothingInput.Text);
            Expenses.instance.medicalInsurance = medicalInsurancelnput.Text == "" ? 0 : Convert.ToDouble(medicalInsurancelnput.Text);
            Expenses.instance.homeInsurance = homeInsuranceInput.Text == "" ? 0 : Convert.ToDouble(homeInsuranceInput.Text);
            Expenses.instance.carInsurance = carInsuranceInput.Text == "" ? 0 : Convert.ToDouble(carInsuranceInput.Text);
            Expenses.instance.entertainment = entertanmentInput.Text == "" ? 0 : Convert.ToDouble(entertanmentInput.Text);
            Expenses.instance.miscellaneous = miscellaneousInput.Text == "" ? 0 : Convert.ToDouble(miscellaneousInput.Text);
            new PieChartGenerator().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if the user clicks the back button, go back to the menu and not create a instance
            new Menu().Show();
            this.Hide();
        }

        // all the getters and setters for the variables
        public double HousePayments
        {
            get
            {
                return housePayments;
            }
            set
            {
                housePayments = value;
            }
        }
        public double CarPayments
        {
            get
            {
                return carPayments;
            }
            set
            {
                carPayments = value;
            }
        }
        public double Utilities
        {

            get
            {
                return utilities;
            }
            set
            {
                utilities = value;
            }
        }
        public double Food
        {

            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }
        public double Clothing
        {

            get
            {
                return clothing;
            }
            set
            {
                clothing = value;
            }
        }
        public double MedicalInsurance
        {

            get
            {
                return medicalInsurance;
            }
            set
            {
                medicalInsurance = value;
            }
        }
        public double HomeInsurance
        {

            get
            {
                return homeInsurance;
            }
            set
            {
                homeInsurance = value;
            }
        }
        public double CarInsurance
        {

            get
            {
                return carInsurance;
            }
            set
            {
                carInsurance = value;
            }
        }
        public double Entertainment
        {

            get
            {
                return entertainment;
            }
            set
            {
                entertainment = value;
            }
        }
        public double Miscellaneous
        {

            get
            {
                return miscellaneous;
            }
            set
            {
                miscellaneous = value;
            }
        }

    }

}
