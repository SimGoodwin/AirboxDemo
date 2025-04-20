using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AirboxDemo.ViewModels
{
    public partial class PhotoViewViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial ImageFile Image { get; set; }

        public PhotoViewViewModel(ImageFile image)
        {
            Image = image;
        }
    }
}
