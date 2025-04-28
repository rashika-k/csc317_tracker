namespace CSC317_Tracker.Models
{
    public class StatisticsModel
    {
        public float TotalIncome { get; set; }
        public float TotalExpenses { get; set; }
        public Dictionary<string, float> CategoryExpenses { get; set; }

        public StatisticsModel()
        {
            CategoryExpenses = new Dictionary<string, float>();
        }
    }
}
