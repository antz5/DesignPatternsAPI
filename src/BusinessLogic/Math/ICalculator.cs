using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Math
{
    /// <summary>
    /// defines the contract to calculate based on operator type
    /// </summary>
    public interface ICalculator
    {
        OperatorEnum Operator { get; }

        decimal CalculateMoney(decimal a, decimal b);
    }
}
