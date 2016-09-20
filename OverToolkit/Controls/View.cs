using OverToolkit.Enums;
using OverToolkit.Helpers;
using System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace OverToolkit.Controls
{
    /// <summary>
    /// Представляет расширенную <see cref="Page"/>.
    /// </summary>
    public partial class View : Page
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public View()
        {
            SizeChanged += View_SizeChanged;
        }

        private async void View_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Phone)
                return;

            if (ApplicationView.GetForCurrentView().Orientation == ApplicationViewOrientation.Portrait)
                await StatusBar.GetForCurrentView().ShowAsync();
            else
                await StatusBar.GetForCurrentView().HideAsync();
        }
    }
}
