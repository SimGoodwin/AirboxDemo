using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxDemo.Services.Settings
{
    public interface IFileService
    {
        /// <summary>
        /// Return all images for a given type
        /// </summary>
        /// <param name="photoType">Type of photo</param>
        /// <returns>Collection of all images of the type given</returns>
        IEnumerable<ImageSource> GetAllImages(SelectedPhotoType photoType);
    }
}
