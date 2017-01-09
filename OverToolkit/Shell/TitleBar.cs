using OverToolkit.Enums;
using OverToolkit.Helpers;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace OverToolkit.Shell
{
    /// <summary>
    /// Представляет панель заголовка окна.
    /// </summary>
    public static class TitleBar
    {
        /// <summary>
        /// Свойство зависимостей видимости панели заголовка окна.
        /// </summary>
        public static readonly DependencyProperty IsVisibleProperty = DependencyProperty.RegisterAttached("IsVisible",
            typeof(bool), typeof(TitleBar), new PropertyMetadata(null, IsVisiblePropertyChanged));

        /// <summary>
        /// Получает значение видимости панели заголовка окна.
        /// </summary>
        public static bool GetIsVisible(DependencyObject d) => (bool)d.GetValue(IsVisibleProperty);

        /// <summary>
        /// Задает значение видимости панели заголовка окна.
        /// </summary>
        public static void SetIsVisible(DependencyObject d, bool value)
        {
            d.SetValue(IsVisibleProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение видимости панели заголовка окна.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void IsVisiblePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = !(bool)e.NewValue;
        }

        /// <summary>
        /// Свойство зависимостей фонового цвета панели заголовка окна.
        /// </summary>
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached("Background",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnBackgroundPropertyChanged));

        /// <summary>
        /// Получает фоновый цвет панели заголовка окна.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetBackground(DependencyObject d) => (SolidColorBrush)d.GetValue(BackgroundProperty);

        /// <summary>
        /// Задает фоновый цвет панели заголовка окна.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetBackground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(BackgroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение фонового цвета панели заголовка окна.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnBackgroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = titleBar.InactiveBackgroundColor = titleBar.ButtonBackgroundColor = titleBar.ButtonInactiveBackgroundColor =
                ((SolidColorBrush)e.NewValue).Color;
        }

        /// <summary>
        /// Свойство зависимостей фонового цвета кнопок управления окном при наведении.
        /// </summary>
        public static readonly DependencyProperty ButtonHoverBackgroundProperty = DependencyProperty.RegisterAttached("ButtonHoverBackground",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnButtonHoverBackgroundPropertyChanged));

        /// <summary>
        /// Получает фоновый цвет кнопок управления окном при наведении.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetButtonHoverBackground(DependencyObject d) => (SolidColorBrush)d.GetValue(ButtonHoverBackgroundProperty);

        /// <summary>
        /// Задает фоновый цвет кнопок управления окном при наведении.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetButtonHoverBackground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(ButtonHoverBackgroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение фонового цвета кнопок управления окном при наведении.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnButtonHoverBackgroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationView.GetForCurrentView().TitleBar.ButtonHoverBackgroundColor = ((SolidColorBrush)e.NewValue).Color;
        }

        /// <summary>
        /// Свойство зависимостей фонового цвета кнопок управления окном при нажатии.
        /// </summary>
        public static readonly DependencyProperty ButtonPressedBackgroundProperty = DependencyProperty.RegisterAttached("ButtonPressedBackground",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnButtonPressedBackgroundPropertyChanged));

        /// <summary>
        /// Получает фоновый цвет кнопок управления окном при нажатии.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetButtonPressedBackground(DependencyObject d) => (SolidColorBrush)d.GetValue(ButtonPressedBackgroundProperty);

        /// <summary>
        /// Задает фоновый цвет кнопок управления окном при нажатии.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetButtonPressedBackground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(ButtonPressedBackgroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение фонового цвета кнопок управления окном при нажатии.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnButtonPressedBackgroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationView.GetForCurrentView().TitleBar.ButtonPressedBackgroundColor = ((SolidColorBrush)e.NewValue).Color;
        }

        /// <summary>
        /// Свойство зависимостей цвета заголовка и кнопок управления окном.
        /// </summary>
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached("Foreground",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnForegroundPropertyChanged));

        /// <summary>
        /// Получает цвет заголовка и кнопок управления окном.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetForeground(DependencyObject d) => (SolidColorBrush)d.GetValue(ForegroundProperty);

        /// <summary>
        /// Задает цвет заголовка и кнопок управления окном.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetForeground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(ForegroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение цвета заголовка и кнопок управления окном.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationView.GetForCurrentView().TitleBar.ForegroundColor = ((SolidColorBrush)e.NewValue).Color;
        }

        /// <summary>
        /// Свойство зависимостей цвета заголовка и элементов кнопок управления неактивным окном.
        /// </summary>
        public static readonly DependencyProperty InactiveForegroundProperty = DependencyProperty.RegisterAttached("InactiveForeground",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnInactiveForegroundPropertyChanged));

        /// <summary>
        /// Получает цвет заголовка и кнопок управления неактивным окном.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetInactiveForeground(DependencyObject d) => (SolidColorBrush)d.GetValue(InactiveForegroundProperty);

        /// <summary>
        /// Задает цвет заголовка и кнопок управления неактивным окном.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetInactiveForeground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(InactiveForegroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение цвета заголовка и кнопок управления неактивным окном.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnInactiveForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationView.GetForCurrentView().TitleBar.InactiveForegroundColor = ((SolidColorBrush)e.NewValue).Color;
        }

        /// <summary>
        /// Свойство зависимостей цвета элементов кнопок управления окном при наведении.
        /// </summary>
        public static readonly DependencyProperty ButtonHoverForegroundProperty = DependencyProperty.RegisterAttached("ButtonHoverForeground",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnButtonHoverForegroundPropertyChanged));

        /// <summary>
        /// Получает цвет элементов кнопок управления окном при наведении.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetButtonHoverForeground(DependencyObject d) => (SolidColorBrush)d.GetValue(ButtonHoverForegroundProperty);

        /// <summary>
        /// Задает цвет элементов кнопок управления окном при наведении.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetButtonHoverForeground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(ButtonHoverForegroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение цвета кнопок управления окном при наведении.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnButtonHoverForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationView.GetForCurrentView().TitleBar.ButtonHoverForegroundColor = ((SolidColorBrush)e.NewValue).Color;
        }

        /// <summary>
        /// Свойство зависимостей цвета элементов кнопок управления окном при нажатии.
        /// </summary>
        public static readonly DependencyProperty ButtonPressedForegroundProperty = DependencyProperty.RegisterAttached("ButtonPressedForeground",
            typeof(SolidColorBrush), typeof(TitleBar), new PropertyMetadata(null, OnButtonPressedForegroundPropertyChanged));

        /// <summary>
        /// Получает цвет элементов кнопок управления окном при нажатии.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        public static SolidColorBrush GetButtonPressedForeground(DependencyObject d) => (SolidColorBrush)d.GetValue(ButtonPressedForegroundProperty);

        /// <summary>
        /// Задает цвет элементов кнопок управления окном при нажатии.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="value">Значение кисти.</param>
        public static void SetButtonPressedForeground(DependencyObject d, SolidColorBrush value)
        {
            d.SetValue(ButtonPressedForegroundProperty, value);
        }

        /// <summary>
        /// Обрабатывает изменение цвета кнопок управления окном при нажатии.
        /// </summary>
        /// <param name="d">Объект зависимостей.</param>
        /// <param name="e">Данные обработчика события.</param>
        private static void OnButtonPressedForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DeviceTypeHelper.GetDeviceFormFactorType() != DeviceFormFactorType.Desktop && DeviceTypeHelper.GetDeviceFormFactorType() !=
                DeviceFormFactorType.Tablet)
                return;
            ApplicationView.GetForCurrentView().TitleBar.ButtonPressedForegroundColor = ((SolidColorBrush)e.NewValue).Color;
        }
    }
}
