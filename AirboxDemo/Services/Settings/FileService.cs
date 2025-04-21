using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxDemo.Services.Settings
{
    public class FileService : IFileService
    {
        /// <inheritdoc cref="IFileService.GetAllImages(SelectedPhotoType)" />
        public IEnumerable<ImageSource> GetAllImages(SelectedPhotoType photoType)
        {
            var images = new List<ImageSource>();

            switch (photoType)
            {  case SelectedPhotoType.None:
                    return images;
                case SelectedPhotoType.Car:
                    images.Add(ImageSource.FromFile("car_1_image.png"));
                    images.Add(ImageSource.FromFile("car_2_image.png"));
                    images.Add(ImageSource.FromFile("car_3_image.png"));
                    images.Add(ImageSource.FromFile("car_4_image.png"));
                    images.Add(ImageSource.FromFile("car_5_image.png"));
                    break;              
                case SelectedPhotoType.Helicopter:
                    images.Add(ImageSource.FromFile("helicopter_1_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_2_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_3_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_4_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_5_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_6_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_7_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_8_image.png"));
                    images.Add(ImageSource.FromFile("helicopter_9_image.png"));
                    break;
                case SelectedPhotoType.Boat:
                    images.Add(ImageSource.FromFile("boat_1_image.png"));
                    images.Add(ImageSource.FromFile("boat_2_image.png"));
                    images.Add(ImageSource.FromFile("boat_3_image.png"));
                    images.Add(ImageSource.FromFile("boat_4_image.png"));
                    images.Add(ImageSource.FromFile("boat_5_image.png"));
                    images.Add(ImageSource.FromFile("boat_6_image.png"));
                    images.Add(ImageSource.FromFile("boat_7_image.png"));
                    break;
            }

            return images;
        }
    }
}
