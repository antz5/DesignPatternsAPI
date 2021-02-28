using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Math.Factory
{
    public class CalculateStrategyFactory : ICalculateStrategyFactory
    {
        private readonly AddOperator _addOperator;
        private readonly SubtractOperator _subtractOperator;
        private readonly MultiplyOperator _multiplyOperator;
        private readonly DivideOperator _divideOperator;

        public CalculateStrategyFactory(AddOperator addOperator, SubtractOperator subtractOperator, MultiplyOperator multiplyOperator, DivideOperator divideOperator)
        {
            _addOperator = addOperator;
            _subtractOperator = subtractOperator;
            _multiplyOperator = multiplyOperator;
            _divideOperator = divideOperator;
        }
        public ICalculator[] Create()
        {
            return new ICalculator[]
            {
                _addOperator,
                _subtractOperator,
                _multiplyOperator,
                _divideOperator
            };
        }
    }
}
