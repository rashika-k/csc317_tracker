using CSC317_Tracker.Models; // Ensure this is included
using System;
using Microsoft.Maui.Controls;

namespace CSC317_Tracker.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = new SettingsModel(); // Sets the BindingContext to the SettingsModel
        }

        private void OnSaveSettingsClicked(object sender, EventArgs e)
        {
            // The logic to save the settings goes here
            DisplayAlert("Settings Saved", "Your settings have been saved successfully.", "OK");
        }
    }
}

