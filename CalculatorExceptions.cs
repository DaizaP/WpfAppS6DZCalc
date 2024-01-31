using System;
using System.Windows;

namespace WpfAppS6DZCalc
{
    class CalculatorExceptions : CalculatorAriphmetics
    {
        public override void Add(string value)
        {
            try
            {
                base.Add(value);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        public override void Div(string value)
        {
            try
            {
                base.Div(value);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        public override void Sub(string value)
        {
            try
            {
                base.Sub(value);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        public override void Mult(string value)
        {
            try
            {
                base.Mult(value);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
    }
}
