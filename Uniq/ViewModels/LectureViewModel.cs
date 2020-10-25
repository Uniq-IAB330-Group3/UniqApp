using Uniq.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MvvmHelpers;
using Xamarin.Forms;
using Uniq.Views;

namespace Uniq.ViewModels
{
    public class LectureViewModel : BaseViewModel
    {

        public ObservableCollection<Lecture> Lectures { get; set; }

        public Command ProfileCommand { get; }

        public LectureViewModel()
        {
            SetupData();

            Title = "Lectures";

            ProfileCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage());
            });
        }

        void SetupData()
        {
            Lectures = new ObservableCollection<Lecture>()
            {
                new Lecture
                {
                    Heading = "Introduction to Mobile Development",
                    Content = "Lorem Ipsum is simply dummy text of the " +
                    "printing and typesetting industry. Lorem Ipsum has been the industry's standard "


                },
                new Lecture
                {
                    Heading = "Overview",
                    Content = "Lorem Ipsum is simply dummy text of the printing an"

                },
                new Lecture
                {
                    Heading = "Preparation before class",
                    Content = "Lorem Ipsum is simply dummy text of the printing and ti"

                }

            };
        }
    }
}
