using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxDemo.Services.Settings
{
    public interface ISettingsService
    {
        SelectedPhotoType PhotoType { get; set; }
    }
}
