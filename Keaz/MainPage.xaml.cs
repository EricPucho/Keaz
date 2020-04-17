using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keaz.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Keaz
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            NavigationPage.SetBackButtonTitle(this, "");

            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new CodePage());
        }
    }


}
