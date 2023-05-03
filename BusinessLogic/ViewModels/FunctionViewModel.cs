using BusinessLogic.Helpers;
using BusinessLogic.Services;
using System.Collections.ObjectModel;

namespace BusinessLogic.ViewModels
{
    /// <summary>
    /// Класс, отвечающий за хранение информации о выбранной функции.
    /// </summary>
    public class FunctionViewModel : BaseViewModel
    {
        private readonly List<double> _coefficientCList;
        private readonly ObservableCollection<TableValuesViewModel> _tableValues;

        /// <summary>
        /// Сервис, отвечающий за вычисление значения данной функции.
        /// </summary>
        public IFunctionValueCalculationService CalculationService { get; }

        /// <summary>
        /// Пользовательские коэффициенты.
        /// </summary>
        public CoeffitientsViewModel CoefficientsVM { get; }

        /// <summary>
        /// Список коэффициентов C.
        /// </summary>
        public List<double> CoefficientCList => _coefficientCList;

        /// <summary>
        /// Название функции.
        /// </summary>
        public string FunctionName { get; }

        /// <summary>
        /// Список табличных значений.
        /// </summary>
        public ObservableCollection<TableValuesViewModel> TableValues => _tableValues;

        /// <summary>
        /// Переопределение метода ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => FunctionName;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя функции.</param>
        /// <param name="coefficientCList">Список коэффициентов C.</param>
        public FunctionViewModel(string name, List<double> coefficientCList, IFunctionValueCalculationService calculationService)
        {
            FunctionName = name;
            _coefficientCList = coefficientCList;
            _tableValues = new ObservableCollection<TableValuesViewModel>();
            CoefficientsVM = new CoeffitientsViewModel();
            CoefficientsVM.CoefficientC = _coefficientCList.First();
            CalculationService = calculationService;
        }
    }
}
