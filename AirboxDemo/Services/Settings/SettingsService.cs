using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxDemo.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        public const string AIRBOX_SHARED_KEY = "airbox_shared_app_key";

        private const string PHOTO_TYPE_KEY = "gs_photo_type";
        private const int PHOTO_TYPE_DEFAULT = (int)SelectedPhotoType.None;

        /// <inheritdoc cref="ISettingsService.PhotoType" />
        public SelectedPhotoType PhotoType
        {
            get => (SelectedPhotoType)Preferences.Default.Get(PHOTO_TYPE_KEY, PHOTO_TYPE_DEFAULT, AIRBOX_SHARED_KEY);
            set => Preferences.Default.Set(PHOTO_TYPE_KEY, (int)value, AIRBOX_SHARED_KEY);
        }
    }

    /// <summary>
    /// Types of photo the app supports
    /// Use the description attribute to set a translation
    /// </summary>
    public enum SelectedPhotoType
    {
        [Description("EnumSelectedPhotoTypeNone")]
        None = 0,
        [Description("EnumSelectedPhotoTypeCar")]
        Car = 1,
        [Description("EnumSelectedPhotoTypeHelicopter")]
        Helicopter = 2,
        [Description("EnumSelectedPhotoTypeBoat")]
        Boat = 3
    }
}
