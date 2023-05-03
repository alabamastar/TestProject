using BusinessLogic.Helpers;
using BusinessLogic.Services;
using BusinessLogic.ViewModels;
using System.Collections.Generic;
using System.Linq;
using UI.Commands;

namespace UI.ViewModels
{
    /// <summary>
    /// Главная VM приложения.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private readonly List<FunctionViewModel> _functionList;
        private FunctionViewModel _selectedFunctionVM;
        private TableValuesViewModel _selectedTableValuesVM;

        /// <summary>
        /// Команда, отвечающая за вычисление значения функции.
        /// </summary>
        public FunctionCalculateCommand CalculateCommand { get; }

        /// <summary>
        /// Список функций.
        /// </summary>
        public List<FunctionViewModel> FunctionList => _functionList;

        /// <summary>
        /// VM текущей выбранной функции.
        /// </summary>
        public FunctionViewModel SelectedFunctionVM
        {
            get => _selectedFunctionVM;
            set => Set(ref _selectedFunctionVM, value);
        }

        /// <summary>
        /// VM текущей выбранной строки DataGrid с табличными значениями.
        /// </summary>
        public TableValuesViewModel SelectedTableValuesVM
        {
            get => _selectedTableValuesVM;
            set => Set(ref _selectedTableValuesVM, value);
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public MainViewModel()
        {
            _functionList = new List<FunctionViewModel>()
            {
                new FunctionViewModel("Линейная", new List<double> { 1, 2, 3, 4, 5 }, LinearFunctionValueCalculationService.Instance),
                new FunctionViewModel("Квадратичная", new List<double> { 10, 20, 30, 40, 50 }, QuadraticFunctionValueCalculationService.Instance),
                new FunctionViewModel("Кубическая", new List<double> { 100, 200, 300, 400, 500 }, CubicFunctionValueCalculationService.Instance),
                new FunctionViewModel("4-ой степени", new List<double> { 1000, 2000, 3000, 4000, 5000 }, FourthPowerFunctionValueCalculationService.Instance),
                new FunctionViewModel("5-ой степени", new List<double> { 10000, 20000, 30000, 40000, 50000 }, FifthPowerFunctionValueCalculationService.Instance),
            };

            _selectedFunctionVM = _functionList.First();
            _selectedTableValuesVM = new TableValuesViewModel();
            CalculateCommand = new FunctionCalculateCommand();
        }
    }
}
