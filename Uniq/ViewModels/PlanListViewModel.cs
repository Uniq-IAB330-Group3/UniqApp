using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Uniq.Models;
using Uniq.Views;

namespace Uniq.ViewModels
{
    public class PlanListViewModel : BaseViewModel
    {
        public ObservableCollection<Announcement> Plans { get; set; }
        public Command AddNewPlanCommand { get; }

        public PlanListViewModel()
        {
            SetupData();

            Title = "Plans";

            AddNewPlanCommand = new Command(async () =>
            {

                await Application.Current.MainPage.Navigation.PushAsync(new AddNewPlanPage());
            });
        }

        void SetupData()
        {
            Plans = new ObservableCollection<Announcement>()
            {
                new Announcement
                {
                    Name = "Meet with John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "tab_about.png",
                    TimePosted = "Tue 11:32am"
                },
                new Announcement
                {
                    Name = "Meet with John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "tab_about.png",
                    TimePosted = "Tue 11:32am"
                },
                new Announcement
                {
                    Name = "Meet with John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "tab_about.png",
                    TimePosted = "Tue 11:32am"
                },
                new Announcement
                {
                    Name = "Meet with John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "tab_about.png",
                    TimePosted = "Tue 11:32am"
                },
                new Announcement
                {
                    Name = "Meet with John Smith",
                    Unit = "CAB202",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ProfileImage = "tab_about.png",
                    TimePosted = "Tue 11:32am"
                }
            };
        }
    }
}