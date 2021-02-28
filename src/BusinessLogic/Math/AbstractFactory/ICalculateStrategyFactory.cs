using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Math.Factory
{
    public interface ICalculateStrategyFactory
    {
        ICalculator[] Create();
    }
}
