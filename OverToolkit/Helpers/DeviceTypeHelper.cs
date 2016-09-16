using OverToolkit.Enums;
using Windows.System.Profile;
using Windows.UI.ViewManagement;

namespace OverToolkit.Helpers
{
    /// <summary>
    /// Класс-помощник определения типа устройства.
    /// </summary>
    public static class DeviceTypeHelper
    {
        /// <summary>
        /// Получает форм-фактор используемого пользователем устройства.
        /// </summary>
        public static DeviceFormFactorType GetDeviceFormFactorType()
        {
            switch (AnalyticsInfo.VersionInfo.DeviceFamily)
            {
                case "Windows.Mobile":
                    return DeviceFormFactorType.Phone;
                case "Windows.Desktop":
                    return UIViewSettings.GetForCurrentView().UserInteractionMode == UserInteractionMode.Mouse
                        ? DeviceFormFactorType.Desktop
                        : DeviceFormFactorType.Tablet;
                case "Windows.Universal":
                    return DeviceFormFactorType.IoT;
                case "Windows.Team":
                    return DeviceFormFactorType.SurfaceHub;
                default:
                    return DeviceFormFactorType.Other;
            }
        }
    }
}
