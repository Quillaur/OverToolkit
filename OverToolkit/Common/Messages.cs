using System;
using Windows.UI.Popups;

namespace OverToolkit.Common
{
    /// <summary>
    /// Статический класс, предназначенный для вывода диалоговых окон.
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// Отображает окно сообщения.
        /// </summary>
        /// <param name="content">Текст, который требуется отобразить в окне.</param>
        /// <param name="title">Заголовок окна.</param>
        public static async void Show(string content, string title)
        {
            await new MessageDialog(content, title).ShowAsync();
        }

        /// <summary>
        /// Отображает окно сообщения.
        /// </summary>
        /// <param name="content">Текст, который требуется отобразить в окне.</param>
        public static async void Show(string content)
        {
            await new MessageDialog(content).ShowAsync();
        }
    }
}
