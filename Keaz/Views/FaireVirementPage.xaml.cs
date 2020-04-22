using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class FaireVirementPage : ContentPage
    {
        public FaireVirementPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new MontantPage());
        }
    }
}