using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalc.Services
{
    public class CalcImplementation
    {
        private List<string> _operationsHistory;

        public CalcImplementation()
        {
            _operationsHistory = new List<string>();
        }

        public int Add(int firstValue, int secondValue)
        {
            int result = firstValue + secondValue;
            _operationsHistory.Insert(0, $"{firstValue} + {secondValue} = {result}");
            return result;
        }

        public double Add(double firstValue, double secondValue)
        {
            double result = firstValue + secondValue;
            _operationsHistory.Insert(0, $"{firstValue} + {secondValue} = {result}");
            return result;
        }

        public int Sub(int firstValue, int secondValue)
        {
            int result = firstValue - secondValue;
            _operationsHistory.Insert(0, $"{firstValue} - {secondValue} = {result}");
            return result;
        }

        public double Sub(double firstValue, double secondValue)
        {
            double result = firstValue - secondValue;
            _operationsHistory.Insert(0, $"{firstValue} - {secondValue} = {result}");
            return result;
        }

        public int Multiply(int firstValue, int secondValue)
        {
            int result = firstValue * secondValue;
            _operationsHistory.Insert(0, $"{firstValue} * {secondValue} = {result}");
            return result;
        }

        public double Multiply(double firstValue, double secondValue)
        {
            double result = firstValue * secondValue;
            _operationsHistory.Insert(0, $"{firstValue} * {secondValue} = {result}");
            return result;
        }
        
        public double Divide(int firstValue, int secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException();
            }
            
            int result = firstValue / secondValue;
            _operationsHistory.Insert(0, $"{firstValue} / {secondValue} = {result}");
            return result;
        }

        public double Divide(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException();
            }
            
            double result = firstValue / secondValue;
            _operationsHistory.Insert(0, $"{firstValue} / {secondValue} = {result}");
            return result;
        }

        public double Pow(double basis, double exponent)
        {
            double result = Math.Pow(basis, exponent);
            _operationsHistory.Insert(0, $"{basis} ** {exponent} = {result}");
            return result;
        }

        public double Root(double value)
        {
            if (value < 0.0)
            {
                throw new ArithmeticException();
            }

            double result = Math.Sqrt(value);
            _operationsHistory.Insert(0, $"sqrt({value}) = {result}");
            return result;
        }

        public List<string> History()
        {
            return _operationsHistory.GetRange(0, 5);
        }
    }
}