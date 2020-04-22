using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class AutresInfoPage : ContentPage
    {
        public AutresInfoPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new RecapVirementPage());
        }
    }
}
