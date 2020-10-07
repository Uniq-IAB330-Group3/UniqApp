using System;
using System.Collections.Generic;
using Uniq.ViewModels;
using Uniq.Views;
using Xamarin.Forms;

namespace Uniq
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AnnouncementsPage), typeof(AnnouncementsPage));
            Routing.RegisterRoute(nameof(TalkPage), typeof(TalkPage));
            Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
            Routing.RegisterRoute(nameof(ExtensionPage), typeof(ExtensionPage));
            Routing.RegisterRoute(nameof(AppointmentPage), typeof(AppointmentPage));
            Routing.RegisterRoute(nameof(ManualPage), typeof(ManualPage));
        }

    }
}
