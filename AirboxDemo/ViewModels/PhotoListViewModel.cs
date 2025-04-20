using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirboxDemo.Pages;
using AirboxDemo.Services;
using AirboxDemo.Services.Settings;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AirboxDemo.ViewModels
{
    public partial class PhotoListViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial ObservableCollection<ImageFile> Images { get; set; } = [];

        private readonly ISettingsService settings;
        private readonly IFileService files;

        public PhotoListViewModel(ISettingsService settingService, IFileService fileService)
        {
            settings = settingService;
            files = fileService;
            SetImages();           
        }

        internal void SetView(SelectedPhotoType photoType)
        {
            settings.PhotoType = photoType;            
            SetImages();
        }

        private void SetImages()
        { 
            Images.Clear();
            foreach (var file in files.GetAllImages(settings.PhotoType))
            {
                Images.Add(new ImageFile(file));
            }
        }

        internal async Task DisplayImage(ImageFile image)
        {
            await Shell.Current.Navigation.PushAsync(new PhotoViewPage(image));
        }
    }
}
