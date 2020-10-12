using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Uniq.Models;
using Uniq.Views;
using System.ComponentModel;

namespace Uniq.ViewModels
{
    public class PlanListViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public ObservableCollection<Planner> Plans { get; set; }
        public Command AddNewPlanCommand { get; }
        ICommand tapCommand;

        public PlanListViewModel()
        {
            SetupData();

            Title = "Plans";

            tapCommand = new Command(OnTapped);

            AddNewPlanCommand = new Command(async () =>
            {

                await Application.Current.MainPage.Navigation.PushAsync(new AddNewPlanPage());
            });
        }

        public ICommand TapCommand
        {
            get { return tapCommand; }
        }
        void OnTapped(object s)
        {
            Application.Current.MainPage.Navigation.PushAsync(new PlanDetailViewPage());
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