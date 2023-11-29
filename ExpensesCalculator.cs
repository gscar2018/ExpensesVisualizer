using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesVisualizer
{
    internal class ExpensesCalculator
    {

        private double housePayments;
        private double carPayments;
        private double utilities;
        private double food;
        private double clothing;
        private double medical;
        private double homeInsurance;
        private double entertainment;
        private double miscellaneous;
        private double totalExpenses;
        private double[] monthlyExpenses;
        private double[] yearlyExpenses;


        // constructor

        public ExpensesCalculator()
        {
            housePayments = 0;
            carPayments = 0;
            utilities = 0;
            food = 0;
            clothing = 0;
            medical = 0;
            homeInsurance = 0;
            entertainment = 0;
            miscellaneous = 0;
            totalExpenses = 0;
            monthlyExpenses = new double[12];
            yearlyExpenses = new double[12];
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
    public double Medical
    {

        get
        {
            return medical;
        }
        set
        {
            medical = value;
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
    public double TotalExpenses
    {

        get
        {
            return totalExpenses;
        }
        set
        {
            totalExpenses = value;
        }
    }
        public double[] MonthlyExpenses
        {

        get
            {
            return monthlyExpenses;
        }
        set
            {
            monthlyExpenses = value;
        }
        }

        public double[] YearlyExpenses
        {
            get { return yearlyExpenses;
            }
            set
            {
                yearlyExpenses = value;
            }
        }

        public void calculateMonthlyExpenses()
        {
            totalExpenses = housePayments + carPayments + utilities + food + clothing + medical + homeInsurance + entertainment + miscellaneous;

            // to get the percent of each expense
            for (int i = 0; i < monthlyExpenses.Length; i++)
            {
                monthlyExpenses[i] = monthlyExpenses[i] / totalExpenses;
            }

           
        }

        public void calculateYearlyExpenses()
        {

        }

    }
}
