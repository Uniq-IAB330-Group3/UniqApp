using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Uniq.Models;
using Uniq.Views;
using System.ComponentModel;
using System.IO.IsolatedStorage;

namespace Uniq.ViewModels
{
    public class PlanListViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public ObservableCollection<Planner> Plans { get; set; }
        public Command AddNewPlanCommand { get; }
        public Command TapCommand { get; }
        public Command RefreshCommand { get; }
        public Command ProfileCommand { get; }

        public PlanListViewModel()
        {
            SetupData();
            Title = "Plans";

            ProfileCommand = new Command(async () =>
            {

                await Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage());
            });

            AddNewPlanCommand = new Command(async () =>
            {

                await Application.Current.MainPage.Navigation.PushAsync(new AddNewPlanPage());
            });

            TapCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PlanDetailViewPage());
            });

            RefreshCommand = new Command(async () =>
            {
                Plans.Clear();
                SetupData();
            });
        }

        void CheckBox_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            Plans.RemoveAt(1);
        }

        public ICommand MoreCommand => new Command<string>(async (string item) =>
        {
            await Application.Current.MainPage.DisplayAlert("AA", "BB", "Ok");

        });

        public ICommand DeleteCommand => new Command<string>(async (string item) =>
        {
            //await Application.Current.MainPage.DisplayAlert("CC", "DD", "Ok");
            
            for (int i=0; i<Plans.Count; i++)
            {
                if (Plans[i].PlanID.Equals(item))
                {
                    Plans.RemoveAt(i);
                    break;
                }
            }
        });

        void SetupData()
        {
            Plans = new ObservableCollection<Planner>()
            {
                new Planner
                {
                    PlanID = "1",
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "timer.png",
                    Date = "Tue 11:32am"
                },
                new Planner
                {
                    PlanID = "2",
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "timer.png",
                    Date = "Tue 11:32am"
                },
                new Planner
                {
                    PlanID = "3",
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "timer.png",
                    Date = "Tue 11:32am"
                },
                new Planner
                {
                    PlanID = "4",
                    Title = "Meet with John Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "timer.png",
                    Date = "Tue 11:32am"
                }
            };
        }
    }
}