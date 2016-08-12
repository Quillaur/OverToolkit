using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel;

namespace OverToolkit.Mvvm
{
    /// <summary>
    /// Представляет средства для обновления свойств.
    /// </summary>
    public class BindableBase : IBindable
    {
        /// <summary>
        /// Обработчик события, определяющий, можно ли выполнить действие после изменения.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Устанавливает значение свойству.
        /// </summary>
        /// <typeparam name="T">Тип.</typeparam>
        /// <param name="storage">Хранилище.</param>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Возвращает <see cref="true"/> или <see cref="false"/> в зависимости от успеха операции.</returns>
        public virtual bool Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
                return false;
            storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Уведомляет клиентов об изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        public virtual void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (DesignMode.DesignModeEnabled)
                return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
