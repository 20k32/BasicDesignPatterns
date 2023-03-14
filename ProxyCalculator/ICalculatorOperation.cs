using System;

namespace ProxyCalculator
{
    public interface ICalculatorOperation<T>
    {
        public Func<T, T, T> Operation { get; set; }
        public T Calculate(T FirstValue, T SecondValue);
        public T Sum(T FirstValue, T SecondValue);
        public T Subtraction(T FirstValue, T SecondValue);
        public T Division(T FirstValue, T SecondValue);
        public T Multiplication(T FirstValue, T SecondValue);
        
    }
}
