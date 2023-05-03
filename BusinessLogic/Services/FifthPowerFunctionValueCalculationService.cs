using BusinessLogic.ViewModels;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис для расчета значения функции 5-ой степени.
    /// </summary>
    public class FifthPowerFunctionValueCalculationService : IFunctionValueCalculationService
    {
        private static readonly FifthPowerFunctionValueCalculationService s_instance = new();

        /// <summary>
        /// Статическая ссылка на экземпляр класса.
        /// </summary>
        public static FifthPowerFunctionValueCalculationService Instance => s_instance;

        /// <summary>
        /// Приватный конструктор класса.
        /// </summary>
        private FifthPowerFunctionValueCalculationService() { }

        /// <summary>
        /// Метод для расчета значения функции 5-ой степени.
        /// </summary>
        /// <param name="values">Набор табличных значений.</param>
        /// <param name="coefficients">Набор пользовательских коэффициентов.</param>
        public void Calculate(TableValuesViewModel values, CoeffitientsViewModel coeffitients)
        {
            values.FunctionValue
                = coeffitients.CoefficientA * Math.Pow(values.VariableX, 5)
                + coeffitients.CoefficientB * Math.Pow(values.VariableY, 4)
                + coeffitients.CoefficientC;
        }
    }
}
