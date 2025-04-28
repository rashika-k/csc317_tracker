using Microcharts;
using Microcharts.Maui;
using CSC317_Tracker.Controllers;
using SkiaSharp;
using System.Linq;
using Microsoft.Maui.Controls;

namespace CSC317_Tracker.Pages
{
    public partial class StatisticsPage : ContentPage
    {
        private readonly ExpenseTrackerController _expenseController;

        public StatisticsPage()
        {
            InitializeComponent();
            _expenseController = ExpenseTrackerController.Instance; 
            LoadCharts();
        }

        private void LoadCharts()
        {
            var expenses = _expenseController.Expenses; 

            float totalIncome = 5000f;

            float totalExpenses = (float)expenses.Sum(e => e.Amount);

            var categoryTotals = expenses
                .GroupBy(e => e.Category)
                .ToDictionary(g => g.Key, g => (float)g.Sum(e => e.Amount));

  
            BarChart.Chart = new BarChart
            {
                Entries = new[]
                {
                    new ChartEntry(totalIncome)
                    {
                        Label = "Income",
                        ValueLabel = totalIncome.ToString("C"),
                        Color = SKColor.Parse("#4CAF50")
                    },
                    new ChartEntry(totalExpenses)
                    {
                        Label = "Expenses",
                        ValueLabel = totalExpenses.ToString("C"),
                        Color = SKColor.Parse("#F44336")
                    }
                },
                LabelTextSize = 30
            };


            List<ChartEntry> pieEntries = new List<ChartEntry>();
            PieLegend.Children.Clear();

            string[] greenShades = new string[]
            {
                "#A8D5BA", "#7FB77E", "#4CAF50", "#2E7D32", "#1B5E20"
            };

            int colorIndex = 0;

            foreach (var categoryEntry in categoryTotals)
            {
                var colorHex = greenShades[colorIndex % greenShades.Length];

                pieEntries.Add(new ChartEntry(categoryEntry.Value)
                {
                    Label = categoryEntry.Key,
                    ValueLabel = "", 
                    Color = SKColor.Parse(colorHex)
                });

                var colorBox = new BoxView
                {
                    WidthRequest = 15,
                    HeightRequest = 15,
                    Color = Color.FromArgb(colorHex)
                };

                var label = new Label
                {
                    Text = categoryEntry.Key,
                    FontSize = 14,
                    VerticalOptions = LayoutOptions.Center
                };

                var item = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 5,
                    Children = { colorBox, label }
                };

                PieLegend.Children.Add(item);

                colorIndex++;
            }

            PieChart.Chart = new PieChart
            {
                Entries = pieEntries,
                LabelTextSize = 25,
                LabelMode = LabelMode.None
            };
        }
    }
}
