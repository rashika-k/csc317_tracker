using CSC317_Tracker.Controllers;

namespace CSC317_Tracker.Pages;
public partial class ExpenseTrackerPage : ContentPage
{
    ExpenseTrackerController controller;
    public ExpenseTrackerPage()
    {
        InitializeComponent();
        controller = new ExpenseTrackerController();
        BindingContext = controller;
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(CategoryInput.Text) || string.IsNullOrWhiteSpace(AmountInput.Text))
            return;
        if (decimal.TryParse(AmountInput.Text, out decimal amount))
        {
            controller.AddExpense(DatePicker.Date, CategoryInput.Text, amount);

            CategoryInput.Text = "";
            AmountInput.Text = "";
        }
    }
}