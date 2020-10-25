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
    public class QuizViewModel : BaseViewModel
    {
        public ObservableCollection<Quiz> Quizs { get; set; }

        public Command ProfileCommand { get; }

        public QuizViewModel()
        {
            SetupData();

            Title = "Quiz";

            ProfileCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage());
            });
        }

        void SetupData()
        {
            Quizs = new ObservableCollection<Quiz>()
            {
                new Quiz
                {
                    Weeks = "Week 1"
                },
                new Quiz
                {
                     Weeks = "Week 2"
                },
                new Quiz
                {
                     Weeks = "Week 3"
                },
                new Quiz
                {
                     Weeks = "Week 4"
                },
                new Quiz
                {
                     Weeks = "Week 5"
                },
                new Quiz
                {
                     Weeks = "Week 6"
                },
                new Quiz
                {
                     Weeks = "Week 7"
                },
                new Quiz
                {
                     Weeks = "Week 8"
                },
                new Quiz
                {
                     Weeks = "Week 9"
                },
                new Quiz
                {
                     Weeks = "Week 10"
                },
                new Quiz
                {
                     Weeks = "Week 11"
                },
                new Quiz
                {
                     Weeks = "Week 12"
                },
                new Quiz
                {
                     Weeks = "Week 13"
                },


            };
        }
    }
}
