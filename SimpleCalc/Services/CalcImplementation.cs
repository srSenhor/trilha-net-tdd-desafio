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
            return firstValue + secondValue;
        }

        public double Add(double firstValue, double secondValue)
        {
            return firstValue  + secondValue;
        }

        public int Sub(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }

        public double Sub(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        public int Multiply(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }

        public double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        
        public int Divide(int firstValue, int secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException();
            }
            
            return firstValue / secondValue;
        }

        public double Divide(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException();
            }
            
            return firstValue / secondValue;
        }

        public int Pow(double basis, double exponent)
        {
            return 0;
        }

        public int Root(double value)
        {
            return 0;
        }

        public double Sin(int value)
        {
            return 0.0;
        }

        public double Cos(int value)
        {
            return 0.0;
        }

        public double Tan(int value)
        {
            return 0.0;
        }

        public List<string> History()
        {
            return new List<string>();
        }
    }
}