using System.ComponentModel;

namespace CSC317_Tracker.Models
{
    public class GoalsModel : INotifyPropertyChanged
    {
        private double _monthlyGoal;
        private double _annualGoal;

        // Simulate current savings for right now
        private double _currentSavings = 500;

        public double MonthlyGoal
        {
            get => _monthlyGoal;
            set
            {
                if (_monthlyGoal != value)
                {
                    _monthlyGoal = value;
                    OnPropertyChanged(nameof(MonthlyGoal));
                    OnPropertyChanged(nameof(MonthlyProgress));
                }
            }
        }

        public double AnnualGoal
        {
            get => _annualGoal;
            set
            {
                if (_annualGoal != value)
                {
                    _annualGoal = value;
                    OnPropertyChanged(nameof(AnnualGoal));
                    OnPropertyChanged(nameof(AnnualProgress));
                }
            }
        }

        public double MonthlyProgress => MonthlyGoal > 0 ? _currentSavings / MonthlyGoal : 0;
        public double AnnualProgress => AnnualGoal > 0 ? _currentSavings / AnnualGoal : 0;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
