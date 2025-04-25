using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC317_Tracker.Models
{
    class DashboardModel
    {
        public string CurrentDate => DateTime.Now.ToString("MMMM dd, yyyy");

    }
}
