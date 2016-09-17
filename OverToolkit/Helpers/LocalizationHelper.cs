using Windows.ApplicationModel.Resources;

namespace OverToolkit.Helpers
{
    /// <summary>
    /// Класс-помощник для работы с локализацией.
    /// </summary>
    public static class LocalizationHelper
    {
        #region Private field
        private static readonly ResourceLoader resourceLoader = ResourceLoader.GetForViewIndependentUse("Resources");
        #endregion

        #region Public method
        /// <summary>
        /// Получает строку из ресурсов *.resw.
        /// </summary>
        /// <param name="resourceName">Название элемента *.resw.</param>
        /// <returns>Строка элемента *.resw.</returns>
        public static string ToString(string resourceName)
        {
            return resourceLoader.GetString(resourceName);
        }
        #endregion
    }
}
