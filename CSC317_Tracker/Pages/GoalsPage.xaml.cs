using System.Threading.Tasks;
using CSC317_Tracker.Models;

namespace CSC317_Tracker.Pages;

public partial class GoalsPage : ContentPage
{
    public GoalsPage()
    {
        InitializeComponent();
        BindingContext = new GoalsModel();
    }
}
