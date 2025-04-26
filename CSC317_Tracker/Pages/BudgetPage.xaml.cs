namespace CSC317_Tracker.Pages;
public partial class BudgetPage : ContentPage
{
    public BudgetPage()
    {
        InitializeComponent();
    }
} private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double budget = double.Parse(this.Controls["txtBudget"].Text);
                double necessities = double.Parse(this.Controls["txtNecessities"].Text);
                double meals = double.Parse(this.Controls["txtMeals"].Text);
                double misc = double.Parse(this.Controls["txtMisc"].Text);

                double totalExpenses = necessities + meals + misc;
                double remaining = budget - totalExpenses;

                this.Controls["lblResult"].Text = $"Remaining Budget: {remaining:C}";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new BudgetForm());
        }
    }
}
