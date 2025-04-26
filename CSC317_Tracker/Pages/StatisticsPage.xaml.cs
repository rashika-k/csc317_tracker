using CSC317_Tracker.Controllers;
using CSC317_Tracker.Models;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.ChartEntry;

namespace CSC317_Tracker.Pages
{
    public partial class StatisticsPage : ContentPage
    {
        private readonly StatisticsController _controller;

        public StatisticsPage()
        {
            InitializeComponent();
            _controller = new StatisticsController();
            LoadCharts();
        }

        private void LoadCharts()
        {
            var expenses = _controller.GetExpenses(); // Replace this with your real data method

            var chartEntries = expenses.Select(e => new Entry((float)e.Amount)
            {
                Label = e.Category,
                ValueLabel = $"${e.Amount}",
                Color = GetColorForCategory(e.Category)
            }).ToList();

            PieChart.Chart = new PieChart { Entries = chartEntries };
            BarChart.Chart = new BarChart { Entries = chartEntries };
        }

        private SKColor GetColorForCategory(string category)
        {
            return category switch
            {
                "Food" => SKColors.Red,
                "Transportation" => SKColors.Blue,
                "Entertainment" => SKColors.Orange,
                "Bills" => SKColors.Green,
                "Others" => SKColors.Gray,
                _ => SKColors.Purple
            };
        }
    }
}
