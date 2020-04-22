using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class MontantPage : ContentPage
    {
        public MontantPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new AutresInfoPage());
        }
    }
}
