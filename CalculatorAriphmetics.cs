using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppS6DZCalc
{
    class CalculatorArgs : EventArgs
    {
        public string answer = "0";
    }
    class CalculatorAriphmetics
    {
        public event EventHandler<CalculatorArgs> Result;
        public string result { get; private set; } = "0";

        Stack<string> results = new Stack<string>();


        private void Calculation()
        {
            Result.Invoke(this, new CalculatorArgs { answer = result });
        }
        public virtual void Add(string value)
        {
            results.Push(result);
            if(double.TryParse(result, out double vD1))
            {
                if (double.TryParse(value, out double vD2))
                {
                    result = (vD1 + vD2).ToString();
                }
            }
            Calculation();
        }

        public virtual void Sub(string value)
        {
            results.Push(result);
            if (double.TryParse(result, out double vD1))
            {
                if (double.TryParse(value, out double vD2))
                {
                    result = (vD1 - vD2).ToString();
                }
            }
            Calculation();
        }

        public virtual void Mult(string value) 
        {
            results.Push(result);
            if (double.TryParse(result, out double vD1))
            {
                if (double.TryParse(value, out double vD2))
                {
                    result = (vD1 * vD2).ToString();
                }
            }
            Calculation();
        }

        public virtual void Div(string value)
        {
            if(value == "0")
            {
                throw new DivideByZeroException();
            }
            results.Push(result);
            if (double.TryParse(result, out double vD1))
            {
                if (double.TryParse(value, out double vD2))
                {
                    result = (vD1 / vD2).ToString();
                }
            }
            Calculation();
        }

        public virtual void Cancel()
        {
            if (results.Count > 0)
            {
                result = results.Pop();
                Calculation();
            }
        }
        public virtual void Clear()
        {
            if (results.Count > 0)
            {
                result = "0";
                results.Clear();
                Calculation();
            }
        }
    }
}
