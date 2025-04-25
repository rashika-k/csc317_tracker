using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC317_Tracker.Models
{
    public class ExpenseTrackerModel
    {
        public DateTime Date {  get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
    }
}
