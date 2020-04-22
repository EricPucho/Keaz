using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new ConnexionPage());
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new InscriptionPage());

        }
    }
}