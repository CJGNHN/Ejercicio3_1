﻿using System;
using System.Collections.Generic;
using Ejercicio3_1.ViewModels;
using Ejercicio3_1.Views;
using Xamarin.Forms;

namespace Ejercicio3_1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AddEmpleadoPage), typeof(AddEmpleadoPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
