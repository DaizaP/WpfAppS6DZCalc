using System;
using System.Windows;

namespace WpfAppS6DZCalc
{
    class CalculatorExceptions : CalculatorAriphmetics
    {
        public override void Add(double value)
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
        public override void Div(double value)
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
        public override void Sub(double value)
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
        public override void Mult(double value)
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
