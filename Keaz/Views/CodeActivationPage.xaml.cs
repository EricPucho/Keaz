using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Keaz.Views
{
    public partial class CodeActivationPage : ContentPage
    {
        public CodeActivationPage()
        {
            InitializeComponent();

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var navigationPage = new Xamarin.Forms.NavigationPage(new MainPage());
            navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.MatchNavigationBarTextLuminosity);

            navigationPage.BarBackgroundColor = Color.FromRgb(10, 99, 52);
            navigationPage.BackgroundColor = Color.White;
            navigationPage.BarTextColor = Color.White;

            App.Current.MainPage = navigationPage;
        }
    }
}