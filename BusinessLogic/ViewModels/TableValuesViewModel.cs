using BusinessLogic.Helpers;

namespace BusinessLogic.ViewModels
{
    /// <summary>
    /// Класс, отвечающий за хранение табличных значений.
    /// </summary>
    public class TableValuesViewModel : BaseViewModel
    {
        private double _functionValue = default;

        /// <summary>
        /// Переменная X.
        /// </summary>
        public double VariableX { get; set; } = default;

        /// <summary>
        /// Переменная Y.
        /// </summary>
        public double VariableY { get; set; } = default;

        /// <summary>
        /// Значение функции f(x,y).
        /// </summary>
        public double FunctionValue
        {
            get => _functionValue;
            set => Set(ref _functionValue, value);
        }
    }
}
