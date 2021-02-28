using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Math.Factory
{
    public class MultiplyOperator : ICalculator
    {
        public OperatorEnum Operator => OperatorEnum.Multiply;

        public decimal CalculateMoney(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
