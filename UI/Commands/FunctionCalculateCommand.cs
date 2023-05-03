using System;
using System.Windows.Input;
using UI.ViewModels;

namespace UI.Commands
{
    /// <summary>
    /// Команда, отвечающая за расчет значения функции.
    /// </summary>
    public class FunctionCalculateCommand : ICommand
    {
        /// <summary>
        /// Событие, сигнализирующее об изменении результата метода CanExecute.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Метод, определяющий допустимость выполнения метода Execute.
        /// </summary>
        /// <param name="parameter">Параметр, переданный из View.</param>
        /// <returns>true - если Execute может быть выполнен; иначе - false.</returns>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Стандартный метод выполнения команды.
        /// </summary>
        /// <param name="parameter">Параметр, переданный из View.</param>
        public void Execute(object? parameter)
        {
            if (parameter is not MainViewModel mainVM)
                return;

            mainVM.SelectedFunctionVM.CalculationService.Calculate(mainVM.SelectedTableValuesVM, mainVM.SelectedFunctionVM.CoefficientsVM);
        }
    }
}
