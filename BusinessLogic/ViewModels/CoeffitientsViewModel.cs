using BusinessLogic.Helpers;

namespace BusinessLogic.ViewModels
{
    /// <summary>
    /// Класс, отвечающий за хранение пользовательских коэффициентов.
    /// </summary>
    public class CoeffitientsViewModel : BaseViewModel
    {
        private double _coefficientC = default;

        /// <summary>
        /// Коэффициент A.
        /// </summary>
        public double CoefficientA { get; set; } = default;

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        public double CoefficientB { get; set; } = default;

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        public double CoefficientC
        {
            get => _coefficientC;
            set => Set(ref _coefficientC, value);
        }
    }
}
