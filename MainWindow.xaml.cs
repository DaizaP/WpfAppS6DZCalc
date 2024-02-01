using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppS6DZCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            calculator.Result += Calculator_Result;
        }

        private void Calculator_Result(object sender, CalculatorArgs e)
        {
            LabelOutAnswer.Content = e.answer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool parse = double.TryParse(TextBoxInputText.Text, out double value);
            string name = (e.Source as FrameworkElement).Name;
            if (!parse)
            {
                MessageBox.Show("Неверно ввели данные");
                TextBoxInputText.Clear();
            }
            switch (name)
            {
                case "ButtonAdd":
                    calculator.Add(value); break;
                case "ButtonSub":
                    calculator.Sub(value); break;
                case "ButtonMult":
                    calculator.Mult(value); break;
                case "ButtonDiv":
                    calculator.Div(value); break;
                case "ButtonCancel":
                    calculator.Cancel(); break;
                case "ButtonClear":
                    calculator.Clear(); break;
                default:
                    MessageBox.Show("Ошибка нажатия");
                    TextBoxInputText.Clear();
                    break;
            }
        }

        private void TextBoxInputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = TextBoxInputText.Text;
            if (str.Contains(","))
            {
                string[] strSptit = str.Split(',');
                string result = new string(strSptit[0].Where(t => char.IsDigit(t)).ToArray()) + "," + new string(strSptit[1].Where(t => char.IsDigit(t)).ToArray());
                TextBoxInputText.Text = result;
                TextBoxInputText.Select(TextBoxInputText.Text.Length, 0);
            }
            else
            {
                string result = new string(str.Where(t => char.IsDigit(t)).ToArray());
                TextBoxInputText.Text = result;
                TextBoxInputText.Select(TextBoxInputText.Text.Length, 0);
            }
        }
    }
}
