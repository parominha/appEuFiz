﻿using appeufiz.ViewModels;
using appeufiz.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace appeufiz
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
            Routing.RegisterRoute(route:"RegisterPage", typeof(RegisterPage));
            Routing.RegisterRoute(route:"LoginPage", typeof(LoginPage));
            Routing.RegisterRoute(route:"ConfigPage", typeof(ConfigPage));
        }

    }
}
    