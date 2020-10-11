using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Uniq.Models;
using Uniq.Views;

namespace Uniq.ViewModels
{
    public class SupportViewModel : BaseViewModel {
        public Command TalkButtonCommand { get; }
        public Command ContactButtonCommand { get; }
        public Command ExtensionButtonCommand { get; }
        public Command AppointmentButtonCommand { get; }
        public Command ManualButtonCommand { get; }

        public SupportViewModel() {
            TalkButtonCommand = new Command(OnTalkPressed);
            ContactButtonCommand = new Command(OnContactPressed);
            ExtensionButtonCommand = new Command(OnExtensionPressed);
            TalkButtonCommand = new Command(OnAppointmentPressed);
            TalkButtonCommand = new Command(OnManualPressed);

            Title = "Support";
        }

        async void OnTalkPressed() {
            await Shell.Current.GoToAsync($"{nameof(TalkPage)}");
        }
        async void OnContactPressed() {
            await Shell.Current.GoToAsync($"{nameof(ContactPage)}");
        }
        async void OnExtensionPressed() {
            await Shell.Current.GoToAsync($"{nameof(ExtensionPage)}");
        }
        async void OnAppointmentPressed() {
            await Shell.Current.GoToAsync($"{nameof(AppointmentPage)}");
        }
        async void OnManualPressed() {
            await Shell.Current.GoToAsync($"{nameof(ManualPage)}");
        }

    }
}