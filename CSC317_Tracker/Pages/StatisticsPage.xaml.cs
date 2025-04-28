using Microcharts;
using Microcharts.Maui;
using CSC317_Tracker.Controllers;
using CSC317_Tracker.Models;
using SkiaSharp;
using System.Linq;

namespace CSC317_Tracker.Pages
{
    public partial class StatisticsPage : ContentPage
    {
        private readonly StatisticsController _controller;
        private readonly ExpenseTrackerController _expenseController;

        public StatisticsPage()
        {
            InitializeComponent();
            _controller = new StatisticsController();
            // _expenseController = new ExpenseTrackerController();
            LoadCharts();
        }

        private void LoadCharts()
        {
            var stats = _controller.GetDummyStatistics();

            BarChart.Chart = new BarChart
            {
                Entries = new[]
                {
                    new ChartEntry(stats.TotalIncome)
                    {
                        Label = "Income",
                        ValueLabel = stats.TotalIncome.ToString("C"),
                        Color = SKColor.Parse("#4CAF50")
                    },
                    new ChartEntry(stats.TotalExpenses)
                    {
                        Label = "Expenses",
                        ValueLabel = stats.TotalExpenses.ToString("C"),
                        Color = SKColor.Parse("#F44336") 
                    }
                },
                LabelTextSize = 30
            };

            List<ChartEntry> pieEntries = new List<ChartEntry>();
            foreach (var category in stats.CategoryExpenses)
            {
                pieEntries.Add(new ChartEntry(category.Value)
                {
                    Label = category.Key,
                    ValueLabel = category.Value.ToString("C"),
                    Color = SKColor.Parse(RandomColor())
                });
            }

            PieChart.Chart = new PieChart
            {
                Entries = pieEntries,
                LabelTextSize = 25,
                LabelMode = LabelMode.None
            };
        }

        private string RandomColor()
        {
            Random random = new Random();
            return String.Format("#{0:X6}", random.Next(0x1000000));
        }
    }
}
