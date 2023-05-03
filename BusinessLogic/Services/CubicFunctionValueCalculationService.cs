using BusinessLogic.ViewModels;
using BusinessLogic.Services;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис для расчета значения кубической функции.
    /// </summary>
    public class CubicFunctionValueCalculationService : IFunctionValueCalculationService
    {
        private static readonly CubicFunctionValueCalculationService s_instance = new();

        /// <summary>
        /// Статическая ссылка на экземпляр класса.
        /// </summary>
        public static CubicFunctionValueCalculationService Instance => s_instance;

        /// <summary>
        /// Приватный конструктор класса.
        /// </summary>
        private CubicFunctionValueCalculationService() { }

        /// <summary>
        /// Метод для расчета значения кубической функции.
        /// </summary>
        /// <param name="values">Набор табличных значений.</param>
        /// <param name="coefficients">Набор пользовательских коэффициентов.</param>
        public void Calculate(TableValuesViewModel values, CoeffitientsViewModel coeffitients)
        {
            values.FunctionValue
                = coeffitients.CoefficientA * Math.Pow(values.VariableX, 3)
                + coeffitients.CoefficientB * Math.Pow(values.VariableY, 2)
                + coeffitients.CoefficientC;
        }
    }
}
