using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Services;
using XamarinTraining.Views;

namespace XamarinTraining
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IDataService, DataService>();
            MainPage = new AppShell();
        }

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
