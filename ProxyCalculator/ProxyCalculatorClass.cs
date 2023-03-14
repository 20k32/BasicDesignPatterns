using System;

namespace ProxyCalculator
{
    public class ProxyCalculatorClass : ICalculatorOperation<string>
    {
        private Calculator calculatorService = null!;

        public const string InvalidOperationNotify = "These operation is invalid";

        private double firstValueDouble = default(double),
                       secondValueDouble = default(double);

        public Func<string, string, string> Operation { get; set; } = null!;

        public ProxyCalculatorClass(Calculator CalculatorService)
        {
            calculatorService = CalculatorService;
        }

        private bool Validate(string FirstValue, string SecondValue, ref double FirstValueDouble, ref double SecondValueDouble ) =>
            double.TryParse(FirstValue, out FirstValueDouble) &&
            double.TryParse(SecondValue, out SecondValueDouble);

        public string Division(string FirstValue, string SecondValue)
        {
            if (Validate(FirstValue, SecondValue, ref firstValueDouble, ref secondValueDouble))
            {
                return calculatorService.Division(firstValueDouble, secondValueDouble).ToString();
            }
            else
            {
                return InvalidOperationNotify;
            }
        }

        public string Multiplication(string FirstValue, string SecondValue)
        {
            if (Validate(FirstValue, SecondValue, ref firstValueDouble, ref secondValueDouble))
            {
                return calculatorService.Multiplication(firstValueDouble, secondValueDouble).ToString();
            }
            else
            {
                return InvalidOperationNotify;
            }
        }

        public string Subtraction(string FirstValue, string SecondValue)
        {
            if (Validate(FirstValue, SecondValue, ref firstValueDouble, ref secondValueDouble))
            {
                return calculatorService.Subtraction(firstValueDouble, secondValueDouble).ToString();
            }
            else
            {
                return InvalidOperationNotify;
            }
        }

        public string Sum(string FirstValue, string SecondValue)
        {
            if (Validate(FirstValue, SecondValue, ref firstValueDouble, ref secondValueDouble))
            {
                return calculatorService.Sum(firstValueDouble, secondValueDouble).ToString();
            }
            else
            {
                return InvalidOperationNotify;
            }
        }

        public string Calculate(string FirstValue, string SecondValue)
        {
            return Operation?.Invoke(FirstValue, SecondValue)!;
        }
    }
}
