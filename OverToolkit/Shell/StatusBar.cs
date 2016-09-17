using OverToolkit.Enums;
using OverToolkit.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace OverToolkit.Shell
{
    /// <summary>
    /// Представляет панель состояния для мобильных устройств.
    /// </summary>
    public static class StatusBar
    {
        /// <summary>
        /// Свойство зависимостей фонового цвета панели состояния.
        /// </summary>
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached("Background",
            typeof(SolidColorBrush), typeof(StatusBar), new PropertyMetadata(null, OnBackgroundPropertyChanged));

        /// <summary>
        /// Получает фоновый цвет панели состояния.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetBackground(DependencyObject d) => (SolidColorBrush)d.GetValue(BackgroundProperty);

        /// <summary>
        /// Задает фоновый цвет панели состояния.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetBackground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(BackgroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение фонового цвета панели состояния.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnBackgroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Phone)
                return;
            Windows.UI.ViewManagement.StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
            statusBar.BackgroundColor = ((SolidColorBrush)e.NewValue).Color;
            statusBar.BackgroundOpacity = 1;
        }

        /// <summary>
        /// Свойство зависимостей цвета элементов панели состояния.
        /// </summary>
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached("Foreground",
            typeof(SolidColorBrush), typeof(StatusBar), new PropertyMetadata(null, OnForegroundPropertyChanged));

        /// <summary>
        /// Получает цвет элементов панели состояния.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetForeground(DependencyObject d) => (SolidColorBrush)d.GetValue(ForegroundProperty);

        /// <summary>
        /// Задает цвет элементов панели состояния.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetForeground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(ForegroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение цвета элементов панели состояния.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Phone)
                return;
            Windows.UI.ViewManagement.StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
            statusBar.ForegroundColor = ((SolidColorBrush)e.NewValue).Color;
        }
    }
}
