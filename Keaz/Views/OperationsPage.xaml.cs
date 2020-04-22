using System;
using System.Collections.Generic;
using System.Linq;
using Keaz.Models;
using Keaz.ViewModels;
using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class OperationsPage : ContentPage
    {
        public OperationsPage()
        {
            InitializeComponent();

            BindingContext = new OperationViewModel();
        }

        void _collectionview_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {

            string current = (e.CurrentSelection.FirstOrDefault() as MenuOperations)?.text;

            if (current == "Faire un virement")
                App.Current.MainPage.Navigation.PushAsync(new FaireVirementPage());


        }
    }
}
