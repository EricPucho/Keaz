using System.ComponentModel;
using CoreGraphics;
using Keaz.iOS.Renderers;
using Keaz.Utils;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Keaz.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        #region Properties

        private UIColor BorderColor = UIColor.White;

        private int BorderWidth = 0;

        private Thickness TextPadding = new Thickness(0);

        #endregion

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var element = ((CustomEntry)sender);

            BorderColor = element.BorderColor.ToUIColor();

            BorderWidth = element.BorderWidth;

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}