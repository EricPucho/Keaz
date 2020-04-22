using Xamarin.Forms;

namespace Keaz.Utils
{
    public class CustomEntry : Xamarin.Forms.Entry
    {
        public static readonly BindableProperty BorderColorProperty =
                  BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEntry));

        public static readonly BindableProperty BorderWidthProperty =
                  BindableProperty.Create(nameof(BorderWidth), typeof(int), typeof(CustomEntry));


        /// <summary>
        /// Set the Border Color of the Entry.
        /// </summary>
        public Color BorderColor
        {
            set { SetValue(BorderColorProperty, value); }
            get { return (Color)GetValue(BorderColorProperty); }
        }

        /// <summary>
        /// Set the Border Width of the Entry.
        /// </summary>
        public int BorderWidth
        {
            set { SetValue(BorderWidthProperty, value); }
            get { return (int)GetValue(BorderWidthProperty); }
        }

    }
}
