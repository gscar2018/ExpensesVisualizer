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

            // make sure user enters a number    
            if (!double.TryParse(housePaymentsinput.Text, out housePayments))
            {
                MessageBox.Show("Please enter a number for house payments");
                housePaymentsinput.Clear();
                housePaymentsinput.Focus();
                return;
            }
            if (!double.TryParse(carPaymentsInput.Text, out carPayments))
            {
                MessageBox.Show("Please enter a number for car payments");
                carPaymentsInput.Clear();
                carPaymentsInput.Focus();
                return;
            }
            if (!double.TryParse(utilitiesInput.Text, out utilities))
            {
                MessageBox.Show("Please enter a number for utilities");
                utilitiesInput.Clear();
                utilitiesInput.Focus();
                return;
            }
            if (!double.TryParse(foodInput.Text, out food))
            {
                MessageBox.Show("Please enter a number for food");
                foodInput.Clear();
                foodInput.Focus();
                return;
            }
            if (!double.TryParse(clothingInput.Text, out clothing))
            {
                MessageBox.Show("Please enter a number for clothing");
                clothingInput.Clear();
                clothingInput.Focus();
                return;
            }
            if (!double.TryParse(medicalInsurancelnput.Text, out medicalInsurance))
            {
                MessageBox.Show("Please enter a number for medical insurance");
                medicalInsurancelnput.Clear();
                medicalInsurancelnput.Focus();
                return;
            }
            if (!double.TryParse(homeInsuranceInput.Text, out homeInsurance))
            {
                MessageBox.Show("Please enter a number for home insurance");
                homeInsuranceInput.Clear();
                homeInsuranceInput.Focus();
                return;
            }
            if (!double.TryParse(carInsuranceInput.Text, out carInsurance))
            {
                MessageBox.Show("Please enter a number for car insurance");
                carInsuranceInput.Clear();
                carInsuranceInput.Focus();
                return;
            }
            if (!double.TryParse(entertanmentInput.Text, out entertainment))
            {
                MessageBox.Show("Please enter a number for entertainment");
                entertanmentInput.Clear();
                entertanmentInput.Focus();
                return;
            }
            if (!double.TryParse(miscellaneousInput.Text, out miscellaneous))
            {
                MessageBox.Show("Please enter a number for miscellaneous");
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
        public void calculateYearlyExpenses()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
