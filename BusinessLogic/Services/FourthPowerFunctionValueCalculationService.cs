using BusinessLogic.ViewModels;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Сервис для расчета значения функции 4-ой степени.
    /// </summary>
    public class FourthPowerFunctionValueCalculationService : IFunctionValueCalculationService
    {
        private static readonly FourthPowerFunctionValueCalculationService s_instance = new();

        /// <summary>
        /// Статическая ссылка на экземпляр класса.
        /// </summary>
        public static FourthPowerFunctionValueCalculationService Instance => s_instance;

        /// <summary>
        /// Приватный конструктор класса.
        /// </summary>
        private FourthPowerFunctionValueCalculationService() { }

        /// <summary>
        /// Метод для расчета значения функции 4-ой степени.
        /// </summary>
        /// <param name="values">Набор табличных значений.</param>
        /// <param name="coefficients">Набор пользовательских коэффициентов.</param>
        public void Calculate(TableValuesViewModel values, CoeffitientsViewModel coeffitients)
        {
            values.FunctionValue
                = (coeffitients.CoefficientA * Math.Pow(values.VariableX, 4))
                + (coeffitients.CoefficientB * Math.Pow(values.VariableY, 3))
                + coeffitients.CoefficientC;
        }
    }
}
