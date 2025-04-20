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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="settingService">App settings</param>
        /// <param name="fileService">File service</param>
        public PhotoListViewModel(ISettingsService settingService, IFileService fileService)
        {
            settings = settingService;
            files = fileService;
            SetImages();           
        }

        /// <summary>
        /// Change the type of images displayed 
        /// </summary>
        /// <param name="photoType">Type of images to display</param>
        public void SetView(SelectedPhotoType photoType)
        {
            if (settings.PhotoType == photoType)
                return;

            settings.PhotoType = photoType;            
            SetImages();
        }

        /// <summary>
        /// Get all images of the type set in settings
        /// </summary>
        public void SetImages()
        { 
            Images.Clear();
            foreach (var file in files.GetAllImages(settings.PhotoType))
            {
                Images.Add(new ImageFile(file));
            }
        }

        /// <summary>
        /// Open a new page for the selected image
        /// </summary>
        /// <param name="image">Chosen image</param>
        /// <returns>Awaitable task opening an image view page</returns>
        internal async Task DisplayImageAsync(ImageFile image)
        {
            await Shell.Current.Navigation.PushAsync(new PhotoViewPage(image));
        }
    }
}
