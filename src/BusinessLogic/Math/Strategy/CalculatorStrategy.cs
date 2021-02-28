using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Math
{
    public class CalculatorStrategy : ICalculatorStrategy
    {
        private readonly ICalculator[] _calculators;

        public CalculatorStrategy(ICalculator[] calculators)
        {
            _calculators = calculators;
        }
        public decimal CalculateMoney(decimal a, decimal b, OperatorEnum op)
        {
            var cal = _calculators.FirstOrDefault(s => s.Operator == op);
            if (cal is null)
            {
                throw new InvalidOperationException($"{nameof(op)} is invalid");
            }
            return cal.CalculateMoney(a, b);
        }
    }
}
