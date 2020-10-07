using System.ComponentModel;
using Xamarin.Forms;
using Uniq.ViewModels;

namespace Uniq.Views
{
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
        {
            InitializeComponent();
            BindingContext = new AppointmentViewModel();
        }
    }
}