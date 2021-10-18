using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTraining.Views;

namespace XamarinTraining.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private string title;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value, nameof(Title));
        }

        public AsyncCommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new AsyncCommand(OnLoginClicked);
        }

        private async Task OnLoginClicked()
        {
            await Task.Delay(1000);
            Title = "hello world";
            await Shell.Current.GoToAsync(nameof(AboutPage));
        }
    }
}
