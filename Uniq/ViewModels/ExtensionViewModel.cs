using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Uniq.Models;
using Xamarin.Forms;

namespace Uniq.ViewModels
{
    public class ExtensionViewModel : BaseViewModel {
        public Command OnTapCommand { get; }

        public ExtensionViewModel() {
            OnTapCommand = new Command(OnTap);
            Title = "Apply for Extension";
        }

        async void OnTap() {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
