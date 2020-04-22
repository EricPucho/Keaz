using System;
using Keaz.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Keaz
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new Xamarin.Forms.NavigationPage(new FirstPage());
            navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetStatusBarTextColorMode(StatusBarTextColorMode.MatchNavigationBarTextLuminosity);

            navigationPage.BarBackgroundColor = Color.White;
            navigationPage.BackgroundColor = Color.FromRgb(10, 99, 52);
            navigationPage.BarTextColor = Color.FromRgb(10, 99, 52);

            //navigationPage.BarBackgroundColor = Color.FromRgb(10, 99, 52);
            //navigationPage.BackgroundColor = Color.White;
            //navigationPage.BarTextColor = Color.White;
            App.Current.MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
