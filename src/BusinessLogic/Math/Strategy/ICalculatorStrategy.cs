using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Math
{
    public interface ICalculatorStrategy
    {
        decimal CalculateMoney(decimal a, decimal b, OperatorEnum op);
    }
}
