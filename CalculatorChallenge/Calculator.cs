using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double[] numbers)
        {
            double sum = 0;
            foreach(double number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public string Div(int x, int y)
        {

            int wholeNumber = x / y;
            int numerator = x % y;
            return $"{wholeNumber} {numerator}/{y}";
        }
    }
}
