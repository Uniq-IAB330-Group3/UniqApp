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
    public class AssessmentViewModel : BaseViewModel
    {
        public ObservableCollection<Assessment> Assessements { get; set; }

        public Command ProfileCommand { get; }

        public AssessmentViewModel()
        {
            SetupData();

            Title = "Assessments";

            ProfileCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage());
            });
        }

        void SetupData()
        {
            Assessements = new ObservableCollection<Assessment>()
            {
                new Assessment
                {
                    Head_1 = "Assessment 1",
                    Head_2 = "Assessment 1 Brief and CRA",
                    Paragraph = "Proin eget lorem feugiat, rutrum orci et, varius metus. Donec lacinia nunc pellentesque lectus suscipit consectetur facilisis sed an."


                },
                new Assessment
                {
                    Head_1 = "Assessment 2",
                    Head_2 = "Assessment 2 Brief and CRA",
                    Paragraph = "Mauris in feugiat lorem. Mauris consequat ultricies massa, sit amet elementum diam vehicula id. Sed porttitor elementum faucibus. Sed."

                },


            };
        }
    }
}
