using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxDemo.Services.Settings
{
    public interface ISettingsService
    {
        /// <summary>
        /// Type of photo selected by user
        /// </summary>
        SelectedPhotoType PhotoType { get; set; }
    }
}
