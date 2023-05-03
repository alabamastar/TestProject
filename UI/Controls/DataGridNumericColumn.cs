using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UI.Controls
{
    /// <summary>
    /// Класс-наследник стандартного TextColumn, допускающий ввод только рациональных чисел.
    /// </summary>
    public class DataGridNumericColumn : DataGridTextColumn
    {
        private string _prevValidInput = "0";

        /// <summary>
        /// Переопределение стандартного PrepareCellForEdit.
        /// </summary>
        /// <param name="editingElement">Изменяемый объект.</param>
        /// <param name="editingEventArgs">Аргументы события.</param>
        /// <returns></returns>
        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs)
        {
            if (editingElement is not TextBox cellValueTextBox)
                return base.PrepareCellForEdit(editingElement, editingEventArgs);

            cellValueTextBox.TextChanged += CellTextChanged;

            return base.PrepareCellForEdit(editingElement, editingEventArgs);
        }

        /// <summary>
        /// Метод для валидации пользовательского ввода.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CellTextChanged(object sender, TextChangedEventArgs args)
        {
            if (sender is not TextBox cellTb)
                return;

            if (double.TryParse(cellTb.Text, out double _))
            {
                _prevValidInput = cellTb.Text;
                return;
            }

            cellTb.Text = _prevValidInput;
        }
    }
}
