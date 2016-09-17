﻿using OverToolkit.Enums;
using OverToolkit.Helpers;
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
    }
}