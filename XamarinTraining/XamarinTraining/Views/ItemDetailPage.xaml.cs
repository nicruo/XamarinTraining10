using System.ComponentModel;
using Xamarin.Forms;
using XamarinTraining.ViewModels;

namespace XamarinTraining.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}