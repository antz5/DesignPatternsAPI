using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Math.Factory
{
    public class DivideOperator : ICalculator
    {
        public OperatorEnum Operator => OperatorEnum.Divide;

        public decimal CalculateMoney(decimal a, decimal b)
        {
            if(b== 0)
            {
                throw new InvalidOperationException($"{nameof(b)} must be greater than 0");
            }

            return a / b;
        }
    }
}
