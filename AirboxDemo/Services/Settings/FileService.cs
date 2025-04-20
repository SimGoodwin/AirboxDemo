using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxDemo.Services.Settings
{
    public class FileService : IFileService
    {
        public IEnumerable<ImageSource> GetAllImages(SelectedPhotoType photoType)
        {
            var images = new List<ImageSource>();

            switch (photoType)
            {  case SelectedPhotoType.None:
                    return images;
                case SelectedPhotoType.Car:
                    images.Add(ImageSource.FromFile("car_1_image"));
                    images.Add(ImageSource.FromFile("car_2_image"));
                    images.Add(ImageSource.FromFile("car_3_image"));
                    images.Add(ImageSource.FromFile("car_4_image"));
                    images.Add(ImageSource.FromFile("car_5_image"));
                    break;              
                case SelectedPhotoType.Helicopter:
                    images.Add(ImageSource.FromFile("helicopter_1_image"));
                    images.Add(ImageSource.FromFile("helicopter_2_image"));
                    images.Add(ImageSource.FromFile("helicopter_3_image"));
                    images.Add(ImageSource.FromFile("helicopter_4_image"));
                    images.Add(ImageSource.FromFile("helicopter_5_image"));
                    images.Add(ImageSource.FromFile("helicopter_6_image"));
                    images.Add(ImageSource.FromFile("helicopter_7_image"));
                    images.Add(ImageSource.FromFile("helicopter_8_image"));
                    images.Add(ImageSource.FromFile("helicopter_9_image"));
                    break;
                case SelectedPhotoType.Boat:
                    images.Add(ImageSource.FromFile("boat_1_image"));
                    images.Add(ImageSource.FromFile("boat_2_image"));
                    images.Add(ImageSource.FromFile("boat_3_image"));
                    images.Add(ImageSource.FromFile("boat_4_image"));
                    images.Add(ImageSource.FromFile("boat_5_image"));
                    images.Add(ImageSource.FromFile("boat_6_image"));
                    images.Add(ImageSource.FromFile("boat_7_image"));
                    break;
            }



            return images;
        }
    }
}
