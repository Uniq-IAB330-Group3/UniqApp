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
    public class ContentsViewModel : BaseViewModel
    {

        public Command ProfileCommand { get; }

        public ContentsViewModel()
        {
            Title = "Contents";

            ProfileCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage());
            });
        }
    }
}
