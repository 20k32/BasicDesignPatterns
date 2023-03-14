using System;

namespace ProxyCalculator
{
    public class Calculator : ICalculatorOperation<double>
    {
        public Func<double, double, double> Operation { get; set; } = null!;

        public double Multiplication(double FirstValue, double SecondValue) => FirstValue * SecondValue;

        public double Division(double FirstValue, double SecondValue) => FirstValue / SecondValue;

        public double Subtraction(double FirstValue, double SecondValue) => FirstValue - SecondValue;

        public double Sum(double FirstValue, double SecondValue) => FirstValue + SecondValue;

        public double Calculate(double FirstValue, double SecondValue)
        {
            return Operation.Invoke(FirstValue, SecondValue);
        }
    }
}
