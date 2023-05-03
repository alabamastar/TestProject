using BusinessLogic.Services;
using BusinessLogic.ViewModels;

namespace TestProjectUnitTest
{
    public class CalcFunctionsTest
    {
        /// <summary>
        /// ���� ������� ��� ������� �������� �������� �������.
        /// </summary>
        [Test]
        public void LinearFunctionTest()
        {
            var tableValues = new TableValuesViewModel()
            {
                VariableX = 5,
                VariableY = 10,
            };

            var coefficients = new CoeffitientsViewModel()
            {
                CoefficientA = 5,
                CoefficientB = 6,
                CoefficientC = 1,
            };

            LinearFunctionValueCalculationService.Instance.Calculate(tableValues, coefficients);

            var precalcValue = 32;
            Assert.That(tableValues.FunctionValue, Is.EqualTo(precalcValue));
        }

        /// <summary>
        /// ���� ������� ��� ������� �������� ������������ �������.
        /// </summary>
        [Test]
        public void QuadraticFunctionTest()
        {
            var tableValues = new TableValuesViewModel()
            {
                VariableX = 5,
                VariableY = 10,
            };

            var coefficients = new CoeffitientsViewModel()
            {
                CoefficientA = 5,
                CoefficientB = 6,
                CoefficientC = 10,
            };

            QuadraticFunctionValueCalculationService.Instance.Calculate(tableValues, coefficients);

            var precalcValue = 195;
            Assert.That(tableValues.FunctionValue, Is.EqualTo(precalcValue));
        }

        /// <summary>
        /// ���� ������� ��� ������� �������� ���������� �������.
        /// </summary>
        [Test]
        public void CubicFunctionTest()
        {
            var tableValues = new TableValuesViewModel()
            {
                VariableX = 5,
                VariableY = 10,
            };

            var coefficients = new CoeffitientsViewModel()
            {
                CoefficientA = 5,
                CoefficientB = 6,
                CoefficientC = 100,
            };

            CubicFunctionValueCalculationService.Instance.Calculate(tableValues, coefficients);

            var precalcValue = 1325;
            Assert.That(tableValues.FunctionValue, Is.EqualTo(precalcValue));
        }

        /// <summary>
        /// ���� ������� ��� ������� �������� ������� 4-�� �������.
        /// </summary>
        [Test]
        public void FourthPowerFunctionTest()
        {
            var tableValues = new TableValuesViewModel()
            {
                VariableX = 5,
                VariableY = 10,
            };

            var coefficients = new CoeffitientsViewModel()
            {
                CoefficientA = 5,
                CoefficientB = 6,
                CoefficientC = 1000,
            };

            FourthPowerFunctionValueCalculationService.Instance.Calculate(tableValues, coefficients);

            var precalcValue = 10125;
            Assert.That(tableValues.FunctionValue, Is.EqualTo(precalcValue));
        }

        /// <summary>
        /// ���� ������� ��� ������� �������� ������� 5-�� �������.
        /// </summary>
        [Test]
        public void FifthPowerFunctionTest()
        {
            var tableValues = new TableValuesViewModel()
            {
                VariableX = 5,
                VariableY = 10,
            };

            var coefficients = new CoeffitientsViewModel()
            {
                CoefficientA = 5,
                CoefficientB = 6,
                CoefficientC = 10000,
            };

            FifthPowerFunctionValueCalculationService.Instance.Calculate(tableValues, coefficients);

            var precalcValue = 85625;
            Assert.That(tableValues.FunctionValue, Is.EqualTo(precalcValue));
        }
    }
}