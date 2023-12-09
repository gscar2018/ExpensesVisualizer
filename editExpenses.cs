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
            // make sure user enters a number but dont have to enter all the numbers
            // only change the data if the user enters a number

            if (!string.IsNullOrEmpty(housePaymentsEditInput.Text))
            {
                Expenses.instance.HousePayments = Convert.ToDouble(housePaymentsEditInput.Text);
            }

            if (!string.IsNullOrEmpty(carPaymentsEditInput.Text))
            {
                Expenses.instance.CarPayments = Convert.ToDouble(carPaymentsEditInput.Text);
            }

            if (!string.IsNullOrEmpty(utilitiesEditInput.Text))
            {
                Expenses.instance.Utilities = Convert.ToDouble(utilitiesEditInput.Text);
            }


            if (!string.IsNullOrEmpty(foodEditInput.Text))
            {
                Expenses.instance.Food = Convert.ToDouble(foodEditInput.Text);
            }


            if (!string.IsNullOrEmpty(clothingEditInput.Text))
            {
                Expenses.instance.Clothing = Convert.ToDouble(clothingEditInput.Text);
            }


            if (!string.IsNullOrEmpty(medicalInsuranceEditInput.Text))
            {
                Expenses.instance.MedicalInsurance = Convert.ToDouble(medicalInsuranceEditInput.Text);
            }

            if (!string.IsNullOrEmpty(homeInsuranceEditInput.Text))
            {
                Expenses.instance.HomeInsurance = Convert.ToDouble(homeInsuranceEditInput.Text);
            }

            if (!string.IsNullOrEmpty(carInsuranceEditInput.Text))
            {
                Expenses.instance.CarInsurance = Convert.ToDouble(carInsuranceEditInput.Text);
            }


            if (!string.IsNullOrEmpty(entertainmentEditInput.Text))
            {
                Expenses.instance.Entertainment = Convert.ToDouble(entertainmentEditInput.Text);
            }


            if (!string.IsNullOrEmpty(miscellaneousEditInput.Text))
            {
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
