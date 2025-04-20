using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AirboxDemo.ViewModels
{
    public partial class ImageFile : ObservableObject
    {
        [ObservableProperty]
        public partial ImageSource Source { get; set; }

        /// <summary>
        /// An observable image controller
        /// </summary>
        /// <param name="source">Image source</param>
        public ImageFile(ImageSource source)
        {
            Source = source;
        }
    }
}
