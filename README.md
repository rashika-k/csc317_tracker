CSC317_Tracker
CSC317_Tracker is a budgeting and expense-tracking application built with .NET MAUI. It provides users with a streamlined way to manage finances, track goals, monitor statistics, and customize settings—all in a clean and responsive UI.

📄 Documentation
This project includes the following documentation:

Model Descriptions: Includes core models such as DashboardModel, GoalsModel, and SettingsModel, each of which binds to specific pages for user data management.

Testing Notes: Manual testing has been done for each form page (BudgetForm, Expense Inputs, Goal Progress) including validation handling and UI behavior under edge cases.

Development Notes:

MVC Model is applied

Pages utilize BindingContext to synchronize user inputs with models.

App uses a tabbed layout defined in AppShell.xaml.


How to Run the Project
 
Prerequisites
.NET 9 SDK

Visual Studio 2022 or 2023 with the .NET MAUI workload installed or VS code

(Optional) Android/iOS emulators or a Windows 10+ device for testing

🛠️ Setup Steps
Clone or Download the Repository

bash
Copy
Edit
git clone https://github.com/your-username/CSC317_Tracker.git
cd CSC317_Tracker
Restore Dependencies

bash
Copy
Edit
dotnet restore
Fix any NuGet Issues If you see errors like duplicate packages, open CSC317_Tracker.csproj and:

Keep only one version of each PackageReference (e.g., Microcharts.Maui 0.9.5.9).

Ensure SkiaSharp is upgraded to 2.88.3 or above.

Build the Project

bash
Copy
Edit
dotnet build
Run the App

For Windows:

bash
Copy
Edit
dotnet build -f net9.0-windows10.0.19041.0
dotnet run -f net9.0-windows10.0.19041.0
For Android/iOS/MacCatalyst:

bash
Copy
Edit
dotnet build -f net9.0-android
dotnet run -f net9.0-android
Debugging in VS Code

Add the following to .vscode/launch.json:

json
Copy
Edit
{
  "version": "0.2.0",
  "configurations": [
    {
      "name": ".NET MAUI Windows Launch",
      "type": "coreclr",
      "request": "launch",
      "preLaunchTask": "build",
      "program": "${workspaceFolder}/bin/Debug/net9.0-windows10.0.19041.0/CSC317_Tracker.exe",
      "cwd": "${workspaceFolder}",
      "console": "internalConsole"
    }
  ]
}
📦 Features
Dashboard with dynamic date display

Expense input and category-based list rendering

Budget calculator with UI form and result display

Goal-setting with progress bars (monthly and annual)

Chart-based visualizations (Pie/Bar via Microcharts)

User settings with theme, birthday, email, and currency

📌 Notes
Ensure you use InitializeComponent() inside each ContentPage constructor.

Microcharts visualizations require SkiaSharp, so version mismatches must be avoided.

All controls are defined using XAML with consistent theming via AppThemeBinding.
