using System;
using Keaz.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Keaz
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "StateTriggers_Experimental" });
            InitializeComponent();

            MainPage = new MainPage();
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
