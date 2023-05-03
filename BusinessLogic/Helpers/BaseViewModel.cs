using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessLogic.Helpers
{
    /// <summary>
    /// Класс базовой VM.
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, сообщающее об изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Метод, вызывающий событие PropertyChanged.
        /// </summary>
        /// <param name="propertyName">Имя свойства, значение которого было изменено.</param>
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Реализация стандартного Set метода для свойств, изменение значения которых должно отслеживаться.
        /// </summary>
        /// <typeparam name="T">Тип свойства.</typeparam>
        /// <param name="field">Ссылка на поле класса.</param>
        /// <param name="value">Новое значение для свойства.</param>
        /// <param name="propertyName">Имя свойства, значение которого было изменено.</param>
        /// <returns></returns>
        protected bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
