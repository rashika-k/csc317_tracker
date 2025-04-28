namespace CSC317_Tracker.Pages;
public partial class BudgetPage : ContentPage
{
    public BudgetPage()
    {
        InitializeComponent();
    }
}
using System;
using Microsoft.Maui.Controls;

namespace BudgetCalculatorApp
{
    public partial class BudgetPage : ContentPage
    {
        public BudgetPage()
        {
            InitializeComponent();
        }

        // Button click event handler
        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            // Parse input values
            bool isValidBudget = decimal.TryParse(BudgetEntry.Text, out decimal budget);
            bool isValidNecessities = decimal.TryParse(NecessitiesEntry.Text, out decimal necessities);
            bool isValidMiscellaneous = decimal.TryParse(MiscellaneousEntry.Text, out decimal miscellaneous);
            bool isValidOther = decimal.TryParse(OtherEntry.Text, out decimal other);
            bool isValidFood = decimal.TryParse(FoodEntry.Text, out decimal food);

            // Check if any value is invalid
            if (!isValidBudget || !isValidNecessities || !isValidMiscellaneous || !isValidOther || !isValidFood)
            {
                DisplayAlert("Error", "Please enter valid numerical values.", "OK");
                return;
            }

            // Calculate total expenses
            decimal totalExpenses = necessities + miscellaneous + other + food;

            // Calculate remaining budget and balance
            decimal remainingBudget = budget - totalExpenses;
            decimal balance = remainingBudget >= 0 ? remainingBudget : 0;

            // Update the labels with the results
            ExpensesTotalLabel.Text = $"Total Expenses: {totalExpenses:C}";
            RemainingBudgetLabel.Text = $"Remaining Budget: {remainingBudget:C}";
            BalanceLabel.Text = $"Balance: {balance:C}";
        }
    }
}
