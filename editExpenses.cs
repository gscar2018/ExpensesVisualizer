namespace ExpensesVisualizer
{
    public partial class editExpenses : Form
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

        public editExpenses()
        {
            InitializeComponent();
        }

        private void editExpenses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Menu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // makes sure user enters a number but dont have to enter all the numbers
            // if the user enters a number and its not a negative number

            
            if (!string.IsNullOrEmpty(housePaymentsEditInput.Text))
            {
                if (!double.TryParse(housePaymentsEditInput.Text, out housePayments) || Convert.ToDouble(housePaymentsEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for House Payments");
                    housePaymentsEditInput.Clear();
                    housePaymentsEditInput.Focus();
                    return;
                }
                Expenses.instance.HousePayments = Convert.ToDouble(housePaymentsEditInput.Text);
            }

            if (!string.IsNullOrEmpty(carPaymentsEditInput.Text))
            {
                if (!double.TryParse(carPaymentsEditInput.Text, out carPayments) || Convert.ToDouble(carPaymentsEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Car Payments");
                    carPaymentsEditInput.Clear();
                    carPaymentsEditInput.Focus();
                    return;
                }
                Expenses.instance.CarPayments = Convert.ToDouble(carPaymentsEditInput.Text);
            }

            if (!string.IsNullOrEmpty(utilitiesEditInput.Text))
            {
                if (!double.TryParse(utilitiesEditInput.Text, out utilities) || Convert.ToDouble(utilitiesEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Utilities");
                    utilitiesEditInput.Clear();
                    utilitiesEditInput.Focus();
                    return;
                }
                Expenses.instance.Utilities = Convert.ToDouble(utilitiesEditInput.Text);
            }

            if (!string.IsNullOrEmpty(foodEditInput.Text))
            {
                if (!double.TryParse(foodEditInput.Text, out food) || Convert.ToDouble(foodEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Food");
                    foodEditInput.Clear();
                    foodEditInput.Focus();
                    return;
                }
                Expenses.instance.Food = Convert.ToDouble(foodEditInput.Text);
            }


            if (!string.IsNullOrEmpty(clothingEditInput.Text))
            {
                if (!double.TryParse(clothingEditInput.Text, out clothing) || Convert.ToDouble(clothingEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for clothing");
                    clothingEditInput.Clear();
                    clothingEditInput.Focus();
                    return;
                }
                Expenses.instance.Clothing = Convert.ToDouble(clothingEditInput.Text);
            }
 

            if (!string.IsNullOrEmpty(medicalInsuranceEditInput.Text))
            {
                if (!double.TryParse(medicalInsuranceEditInput.Text, out medicalInsurance) || Convert.ToDouble(medicalInsuranceEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Medical Insurance");
                    medicalInsuranceEditInput.Clear();
                    medicalInsuranceEditInput.Focus();
                    return;
                }
                Expenses.instance.MedicalInsurance = Convert.ToDouble(medicalInsuranceEditInput.Text);
            }

            if (!string.IsNullOrEmpty(homeInsuranceEditInput.Text))
            {
                if (!double.TryParse(homeInsuranceEditInput.Text, out homeInsurance) || Convert.ToDouble(homeInsuranceEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Home Insurance");
                    homeInsuranceEditInput.Clear();
                    homeInsuranceEditInput.Focus();
                    return;
                }
                Expenses.instance.HomeInsurance = Convert.ToDouble(homeInsuranceEditInput.Text);
            }


            if (!string.IsNullOrEmpty(carInsuranceEditInput.Text))
            {
                if (!double.TryParse(carInsuranceEditInput.Text, out carInsurance) || Convert.ToDouble(carInsuranceEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Car Insurance");
                    carInsuranceEditInput.Clear();
                    carInsuranceEditInput.Focus();
                    return;
                }
                Expenses.instance.CarInsurance = Convert.ToDouble(carInsuranceEditInput.Text);
            }


            if (!string.IsNullOrEmpty(entertainmentEditInput.Text))
            {
                if (!double.TryParse(entertainmentEditInput.Text, out entertainment) || Convert.ToDouble(entertainmentEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for Entertainment");
                    entertainmentEditInput.Clear();
                    entertainmentEditInput.Focus();
                    return;
                }
                Expenses.instance.Entertainment = Convert.ToDouble(entertainmentEditInput.Text);
            }


            if (!string.IsNullOrEmpty(miscellaneousEditInput.Text))
            {
                if (!double.TryParse(miscellaneousEditInput.Text, out housePayments) || Convert.ToDouble(miscellaneousEditInput.Text) < 0)
                {
                    MessageBox.Show("Please enter a valid number for miscellaneous");
                    miscellaneousEditInput.Clear();
                    miscellaneousEditInput.Focus();
                    return;
                }
                Expenses.instance.Miscellaneous = Convert.ToDouble(miscellaneousEditInput.Text);
            }

            new Menu().Show();
            this.Hide();
        }

        private void editExpenses_Load_1(object sender, EventArgs e)
        {
            // setting varible data to the data from the Expenses class
            housePayments = Expenses.instance.HousePayments;
            carPayments = Expenses.instance.CarPayments;
            utilities = Expenses.instance.Utilities;
            food = Expenses.instance.Food;
            clothing = Expenses.instance.Clothing;
            medicalInsurance = Expenses.instance.MedicalInsurance;
            homeInsurance = Expenses.instance.HomeInsurance;
            carInsurance = Expenses.instance.CarInsurance;
            entertainment = Expenses.instance.Entertainment;
            miscellaneous = Expenses.instance.Miscellaneous;

            // change labels to display the data from the Expenses class
            housePaymentsEdit.Text = housePayments.ToString();
            carEdit.Text = carPayments.ToString();
            utilitiesEdit.Text = utilities.ToString();
            foodEdit.Text = food.ToString();
            clothingEdit.Text = clothing.ToString();
            medicalEdit.Text = medicalInsurance.ToString();
            homeEdit.Text = homeInsurance.ToString();
            insuranceEdit.Text = carInsurance.ToString();
            entertainmentEdit.Text = entertainment.ToString();
            miscellaneousEdit.Text = miscellaneous.ToString();

        }
    }
}
