
﻿using CSC317_Tracker.Models;

namespace CSC317_Tracker.Controllers
{
    public class StatisticsController
    {
        public List<Expense> GetExpenses()
        {
            return new List<Expense>
            {
                new Expense { Category = "Food", Amount = 150 },
                new Expense { Category = "Transportation", Amount = 80 },
                new Expense { Category = "Entertainment", Amount = 60 },
                new Expense { Category = "Bills", Amount = 200 },
                new Expense { Category = "Others", Amount = 40 }
            };
        }
    }
}
