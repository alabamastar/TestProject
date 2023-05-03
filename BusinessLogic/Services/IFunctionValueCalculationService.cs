using BusinessLogic.ViewModels;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Интерфейс, описывающий сервис для расчета значения функции.
    /// </summary>
    public interface IFunctionValueCalculationService
    {
        /// <summary>
        /// Метод для расчета значения функции.
        /// </summary>
        /// <param name="values">Набор табличных значений.</param>
        /// <param name="coefficients">Набор пользовательских коэффициентов.</param>
        public void Calculate(TableValuesViewModel values, CoeffitientsViewModel coeffitients);
    }
}
