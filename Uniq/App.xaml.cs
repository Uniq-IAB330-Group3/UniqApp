using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Uniq.Services;
using Uniq.Views;

namespace Uniq
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public static string User = "Rendy";

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
