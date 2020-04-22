using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Keaz.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.SelectedTabColor = Color.FromHex("#8dea65");
            this.BackgroundColor = Color.White;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            if (this.CurrentPage.Title == "Comptes")
                NavigationPage.SetTitleView(this, new TitleContentView());
            else
            {
                Title = this.CurrentPage.Title;
                NavigationPage.SetTitleView(this, null);
            }
        }
    }
}