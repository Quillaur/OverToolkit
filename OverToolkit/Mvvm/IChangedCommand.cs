using System.Windows.Input;

namespace OverToolkit.Mvvm
{
    /// <summary>
    /// Расширение <see cref="ICommand"/>, позволяющее вызывать вручную <see cref="ICommand.CanExecuteChanged"/>
    /// </summary>
    public interface IChangedCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}
