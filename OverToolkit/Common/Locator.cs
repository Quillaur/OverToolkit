namespace OverToolkit.Common
{
    /// <summary>
    /// Представляет локатор помощника навигации. 
    /// </summary>
    public static class Locator
    {
        /// <summary>
        /// Помощник навигации.
        /// </summary>
        public static INavigationHelper NavigationHelper { get; private set; }

        /// <summary>
        /// Инициализирует помощник навигации.
        /// </summary>
        /// <param name="navigationHelper">Экземпляр помощника навигации.</param>
        public static void InitializeNavigationHelper(INavigationHelper navigationHelper)
        {
            NavigationHelper = navigationHelper;
        }
    }
}
