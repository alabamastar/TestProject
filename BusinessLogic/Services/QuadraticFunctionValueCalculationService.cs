using BusinessLogic.ViewModels;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис для расчета значения квадратичной функции.
    /// </summary>
    public class QuadraticFunctionValueCalculationService : IFunctionValueCalculationService
    {
        private static readonly QuadraticFunctionValueCalculationService s_instance = new();

        /// <summary>
        /// Статическая ссылка на экземпляр класса.
        /// </summary>
        public static QuadraticFunctionValueCalculationService Instance => s_instance;

        /// <summary>
        /// Приватный конструктор класса.
        /// </summary>
        private QuadraticFunctionValueCalculationService() { }

        /// <summary>
        /// Метод для расчета значения квадратичной функции.
        /// </summary>
        /// <param name="values">Набор табличных значений.</param>
        /// <param name="coefficients">Набор пользовательских коэффициентов.</param>
        public void Calculate(TableValuesViewModel values, CoeffitientsViewModel coeffitients)
        {
            values.FunctionValue
                = (coeffitients.CoefficientA * Math.Pow(values.VariableX, 2))
                + (coeffitients.CoefficientB * Math.Pow(values.VariableY, 1))
                + coeffitients.CoefficientC;
        }
    }
}
