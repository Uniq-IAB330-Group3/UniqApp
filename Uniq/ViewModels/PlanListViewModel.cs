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
        public ObservableCollection<Planner> Plans { get; set; }
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
            Plans = new ObservableCollection<Planner>()
            {
                new Planner
                {
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "tab_about.png",
                    Date = "Tue 11:32am"
                },
                new Planner
                {
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "tab_about.png",
                    Date = "Tue 11:32am"
                },
                new Planner
                {
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "tab_about.png",
                    Date = "Tue 11:32am"
                },
                new Planner
                {
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "tab_about.png",
                    Date = "Tue 11:32am"
                }
            };
        }
    }
}