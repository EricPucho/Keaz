using System;
using System.Collections.Generic;
using Keaz.ViewModels;
using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class ComptePage : ContentPage
    {
        public ComptePage()
        {
            InitializeComponent();
            BindingContext = new CompteViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _stack0.WidthRequest = this.Width;
        }

        void _collectionview_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new DetailsVirementPage());
        }
    }
}
