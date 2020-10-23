using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Uniq.Models;
using Xamarin.Forms;

namespace Uniq.ViewModels
{
    public class AppointmentViewModel : BaseViewModel
    {
        public Command OnTapCommand { get; }

        public AppointmentViewModel() {
            OnTapCommand = new Command(OnTap);
            Title = "Book Councillor Appointment";
        }

        async void OnTap() {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
