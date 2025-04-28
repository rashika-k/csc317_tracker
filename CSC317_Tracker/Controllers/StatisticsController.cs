using CSC317_Tracker.Models;

namespace CSC317_Tracker.Controllers
{
    public class StatisticsController
    {
        public StatisticsModel GetDummyStatistics()
        {
            var stats = new StatisticsModel
            {
                TotalIncome = 5000,
                TotalExpenses = 3200,
                CategoryExpenses = new Dictionary<string, float>
                {
                    { "Food", 800 },
                    { "Rent", 1500 },
                    { "Utilities", 400 },
                    { "Entertainment", 300 },
                    { "Transportation", 200 }
                }
            };

            return stats;
        }
    }
}
