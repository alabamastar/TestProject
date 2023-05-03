using BusinessLogic.ViewModels;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис для расчета значения линейной функции.
    /// </summary>
    public class LinearFunctionValueCalculationService : IFunctionValueCalculationService
    {
        private static readonly LinearFunctionValueCalculationService s_instance = new();

        /// <summary>
        /// Статическая ссылка на экземпляр класса.
        /// </summary>
        public static LinearFunctionValueCalculationService Instance => s_instance;

        /// <summary>
        /// Приватный конструктор класса.
        /// </summary>
        private LinearFunctionValueCalculationService() { }

        /// <summary>
        /// Метод для расчета значения линейной функции.
        /// </summary>
        /// <param name="values">Набор табличных значений.</param>
        /// <param name="coefficients">Набор пользовательских коэффициентов.</param>
        public void Calculate(TableValuesViewModel values, CoeffitientsViewModel coeffitients)
        {
            values.FunctionValue
                = (coeffitients.CoefficientA * values.VariableX)
                + (coeffitients.CoefficientB * Math.Pow(values.VariableY, 0))
                + coeffitients.CoefficientC;
        }
    }
}
