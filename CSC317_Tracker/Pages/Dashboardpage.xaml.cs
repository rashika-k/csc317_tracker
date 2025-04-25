using System.Threading.Tasks;
using CSC317_Tracker.Models;

namespace CSC317_Tracker.Pages;
public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        BindingContext = new DashboardModel();
    }
}