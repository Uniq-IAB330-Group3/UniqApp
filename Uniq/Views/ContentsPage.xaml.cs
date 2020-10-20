using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uniq.Views
{
    public partial class ContentsPage : ContentPage
    {
        public ContentsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //go to lecture page
            await Navigation.PushAsync(new LecturePage());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            //go to tutorial page
            await Navigation.PushAsync(new TutorialPage());

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            //go to Assessment page
            await Navigation.PushAsync(new AssessmentPage());

        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            //go to Quiz page
            await Navigation.PushAsync(new QuizPage());

        }
    }
}