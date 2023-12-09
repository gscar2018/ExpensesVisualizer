namespace ExpensesVisualizer
{
    public partial class PieChartGenerator : Form
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
        private double totalExpenses;
        private double yearlyHousePayments;
        private double yearlyCarPayments;
        private double yearlyUtilities;
        private double yearlyFood;
        private double yearlyClothing;
        private double yearlyMedicalInsurance;
        private double yearlyHomeInsurance;
        private double yearlyCarInsurance;
        private double yearlyEntertainment;
        private double yearlyMiscellaneous;
        private double yearlyTotalExpenses;



        //create an instance of the pie chart generator
        public static PieChartGenerator instance = new PieChartGenerator();

        public PieChartGenerator()
        {
            InitializeComponent();

        }

        //pass data into generate pie chart
        public void generatePieChart()
        {


            //add all the expenses to the total expenses
            totalExpenses = housePayments + carPayments + utilities + food + clothing + medicalInsurance + homeInsurance + carInsurance + entertainment + miscellaneous;

            //adds each monthly expense and creeates a yearly expense pie chart
            yearlyHousePayments = housePayments * 12;
            yearlyCarPayments = carPayments * 12;
            yearlyUtilities = utilities * 12;
            yearlyFood = food * 12;
            yearlyClothing = clothing * 12;
            yearlyMedicalInsurance = medicalInsurance * 12;
            yearlyHomeInsurance = homeInsurance * 12;
            yearlyCarInsurance = carInsurance * 12;
            yearlyEntertainment = entertainment * 12;
            yearlyMiscellaneous = miscellaneous * 12;

            //convert to perecents 
            housePayments /= totalExpenses;
            carPayments /= totalExpenses;
            utilities /= totalExpenses;
            food /= totalExpenses;
            clothing /= totalExpenses;
            medicalInsurance /= totalExpenses;
            homeInsurance /= totalExpenses;
            carInsurance /= totalExpenses;
            entertainment /= totalExpenses;
            miscellaneous /= totalExpenses;

            // adds the data to the pie chart
            ThisMonthyExpense.Series["Series1"].Points.AddXY("House Payments", housePayments);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Car Payments", carPayments);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Utilities", utilities);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Food", food);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Clothing", clothing);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Medical Insurance", medicalInsurance);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Home Insurance", homeInsurance);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Car Insurance", carInsurance);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Entertainment", entertainment);
            ThisMonthyExpense.Series["Series1"].Points.AddXY("Miscellaneous", miscellaneous);

            //display numbers in the pie chart
            ThisMonthyExpense.Series["Series1"].IsValueShownAsLabel = true;
            //show as perecents in the pie chart
            ThisMonthyExpense.Series["Series1"].LabelFormat = "#.##%";


            // get total yearly expenses
             yearlyTotalExpenses = yearlyHousePayments + yearlyCarPayments +
              yearlyUtilities + yearlyFood + yearlyClothing +
              yearlyMedicalInsurance + yearlyHomeInsurance + yearlyCarInsurance + yearlyEntertainment + yearlyMiscellaneous;

            //adds all the yearly expenses to the piechart
            YearlyExpenses.Series["Series1"].Points.AddXY("House Payments", yearlyHousePayments);
            YearlyExpenses.Series["Series1"].Points.AddXY("Car Payments", yearlyCarPayments);
            YearlyExpenses.Series["Series1"].Points.AddXY("Utilities", yearlyUtilities);
            YearlyExpenses.Series["Series1"].Points.AddXY("Food", yearlyFood);
            YearlyExpenses.Series["Series1"].Points.AddXY("Clothing", yearlyClothing);
            YearlyExpenses.Series["Series1"].Points.AddXY("Medical Insurance", yearlyMedicalInsurance);
            YearlyExpenses.Series["Series1"].Points.AddXY("Home Insurance", yearlyHomeInsurance);
            YearlyExpenses.Series["Series1"].Points.AddXY("Car Insurance", yearlyCarInsurance);
            YearlyExpenses.Series["Series1"].Points.AddXY("Entertainment", yearlyEntertainment);
            YearlyExpenses.Series["Series1"].Points.AddXY("Miscellaneous", yearlyMiscellaneous);
            // adds $ to the labels
            YearlyExpenses.Series["Series1"].Label = "#VALY{C}";
            //display numbers in the pie chart
            YearlyExpenses.Series["Series1"].IsValueShownAsLabel = true;
            //set labels to display the total expenses
              yearlyTotalExpensesLabel.Text = yearlyTotalExpenses.ToString();

        }

        private void PieChartGenerator_Load(object sender, EventArgs e)
        {
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
            generatePieChart();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
