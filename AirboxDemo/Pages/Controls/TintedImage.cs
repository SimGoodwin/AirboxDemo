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
        public static readonly BindableProperty TintColorProperty = BindableProperty.Create(
            nameof(TintColor), typeof(Color), typeof(TintedImage), Colors.Transparent, 
            BindingMode.TwoWay, propertyChanged: OnTintColorPropertyChanged);

        /// <summary>
        /// New image colour
        /// </summary>
        public Color TintColor
        {
            get => (Color)GetValue(TintColorProperty);
            set => SetValue(TintColorProperty, value);
        }

        /// <summary>
        /// Update an image's tint colour
        /// </summary>
        /// <param name="bindable">Image</param>
        /// <param name="oldValue">Old colour</param>
        /// <param name="newValue">New colour</param>
        private static void OnTintColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (TintedImage)bindable;
            control.Behaviors.Add(new IconTintColorBehavior { TintColor = (Color)newValue });
        }
    }
}
