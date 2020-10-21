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
        public Command OnTapCommand { get; }

        public ObservableCollection<SupportButton> Buttons { get; set; }

        public SupportViewModel() {
            OnTapCommand = new Command(() => { OnTapped(nameof(TalkPage)); });

            SetupData();

            Title = "Support";
        }

        void SetupData() {
            Buttons = new ObservableCollection<SupportButton>()
            {
                new SupportButton
                {
                    Icon = "profile.png",
                    Text = "Talk to Support",
                    Command = new Command(() => { OnTapped(nameof(TalkPage)); })
        },
                new SupportButton
                {
                    Icon = "sortBy.png",
                    Text = "Contact Tutor",
                    Command = new Command(() => { OnTapped(nameof(ContactPage)); })
                },
                new SupportButton
                {
                    Icon = "timer.png",
                    Text = "Apply for Extension",
                    Command = new Command(() => { OnTapped(nameof(ExtensionPage)); })
                },
                new SupportButton
                {
                    Icon = "chat.png",
                    Text = "Book Councillor Appointment",
                    Command = new Command(() => { OnTapped(nameof(AppointmentPage)); })
                },
                new SupportButton
                {
                    Icon = "tab_feed.png",
                    Text = "Other Support Services",
                    Command = new Command(() => { OnTapped("Other"); })
                },
                new SupportButton
                {
                    Icon = "tab_about.png",
                    Text = "App Manual",
                    Command = new Command(() => { OnTapped(nameof(ManualPage)); })
                }
            };
        }

        async void OnTapped(string destination) {
            if (destination != "Other") 
            {
                await Shell.Current.GoToAsync($"{destination}");
            }
        }
    }
}
