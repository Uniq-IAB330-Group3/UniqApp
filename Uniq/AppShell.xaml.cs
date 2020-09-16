﻿using System;
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
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AnnouncementsPage), typeof(AnnouncementsPage));
        }

    }
}
