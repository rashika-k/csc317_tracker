using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Android.Database;
using CSC317_Tracker.Models;
using System.Collections.ObjectModel;
//using static CSC317_Tracker.Models.ExpenseTrackerModel;


namespace CSC317_Tracker.Controllers
{
    class ExpenseTrackerController : INotifyPropertyChanged
    {
        public ObservableCollection<ExpenseTrackerModel> Expenses { get; } = new ObservableCollection<ExpenseTrackerModel>();

        public void AddExpense(DateTime date, string category, decimal amount)
        {
            if (!string.IsNullOrEmpty(category) && amount > 0)
            {
                Expenses.Add(new ExpenseTrackerModel
                {
                    Date = date,
                    Category = category,
                    Amount = amount
                });
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
