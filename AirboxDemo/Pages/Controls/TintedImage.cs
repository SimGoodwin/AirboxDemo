using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Behaviors;

namespace AirboxDemo.Pages.Controls
{
    /// <summary>
    /// Class to override the colour of an image
    /// </summary>
    internal class TintedImage : Image
    {
        /// <summary>
        /// New image colour
        /// </summary>
        public Color TintColor
        {
            get => (Color)GetValue(TintColorProperty);
            set => SetValue(TintColorProperty, value);
        }

        public static readonly BindableProperty TintColorProperty = BindableProperty.Create(
            nameof(TintColor), typeof(Color), typeof(TintedImage), Colors.Transparent, BindingMode.TwoWay, propertyChanged: OnTintColorPropertyChanged);

        private static void OnTintColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var conrol = (TintedImage)bindable;
            conrol.Behaviors.Add(new IconTintColorBehavior { TintColor = (Color)newValue });
        }
    }
}
