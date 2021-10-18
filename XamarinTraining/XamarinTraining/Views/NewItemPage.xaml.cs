using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinTraining.Domain;
using XamarinTraining.ViewModels;

namespace XamarinTraining.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Character Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}