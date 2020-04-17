using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Keaz.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var navigationPage = new Xamarin.Forms.NavigationPage(new MainPage());
            //navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetPrefersLargeTitles(true);
            //navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.DoNotAdjust);


            navigationPage.BarBackgroundColor = Color.FromRgb(10, 99, 52);
            if (Device.RuntimePlatform == Device.iOS)
                navigationPage.BackgroundColor = Color.FromRgb(10, 99, 52);
            navigationPage.BarTextColor = Color.White;


            App.Current.MainPage = navigationPage;

        }

    }
}
