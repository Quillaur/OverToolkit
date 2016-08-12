using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OverToolkit.Mvvm
{
    /// <summary>
    /// Расширение <see cref="ICommand"/>, позволяющее вызывать вручную <see cref="INotifyPropertyChanged.PropertyChanged"/>
    /// </summary>
    public interface IBindable : INotifyPropertyChanged
    {
        void RaisePropertyChanged([CallerMemberName]string propertyName = null);
    }
}
