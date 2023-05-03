using System.Windows.Controls;
using System.Windows.Input;

namespace UI.Controls
{
    /// <summary>
    /// Класс-наследник стандартного TextBox, допускающий ввод только рациональных чисел.
    /// </summary>
    public class NumericTextBox : TextBox
    {
        private string _prevValidInput = "0";

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public NumericTextBox()
        {
            TextChanged += OnTextChanged;
        }

        /// <summary>
        /// Метод-обработчик события изменения текста.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(Text, out double _))
            {
                _prevValidInput = Text;
                return;
            }

            Text = _prevValidInput;
        }
    }
}
