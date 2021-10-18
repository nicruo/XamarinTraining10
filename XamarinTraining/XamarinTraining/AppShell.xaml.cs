using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinTraining.ViewModels;
using XamarinTraining.Views;

namespace XamarinTraining
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        }
    }
}
