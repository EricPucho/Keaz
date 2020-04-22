using System;
using System.Collections.Generic;
using Keaz.ViewModels;
using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class DetailsVirementPage : ContentPage
    {
        public DetailsVirementPage()
        {
            InitializeComponent();
            BindingContext = new DetailsVirementViewModel();
        }
    }
}
