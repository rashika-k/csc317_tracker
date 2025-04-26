using System;
using System.ComponentModel;

namespace CSC317_Tracker.Models
{
    public class SettingsModel : INotifyPropertyChanged
    {
        private string _userName;
        private string _userEmail;
        private DateTime _userBirthday;
        private string _selectedCurrency;
        private string _selectedTheme;

        public string UserName
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }

        public string UserEmail
        {
            get => _userEmail;
            set
            {
                if (_userEmail != value)
                {
                    _userEmail = value;
                    OnPropertyChanged(nameof(UserEmail));
                }
            }
        }

        public DateTime UserBirthday
        {
            get => _userBirthday;
            set
            {
                if (_userBirthday != value)
                {
                    _userBirthday = value;
                    OnPropertyChanged(nameof(UserBirthday));
                }
            }
        }

        public string SelectedCurrency
        {
            get => _selectedCurrency;
            set
            {
                if (_selectedCurrency != value)
                {
                    _selectedCurrency = value;
                    OnPropertyChanged(nameof(SelectedCurrency));
                }
            }
        }

        public string SelectedTheme
        {
            get => _selectedTheme;
            set
            {
                if (_selectedTheme != value)
                {
                    _selectedTheme = value;
                    OnPropertyChanged(nameof(SelectedTheme));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
