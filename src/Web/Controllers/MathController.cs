using BusinessLogic;
using BusinessLogic.Math;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : Controller
    {
        private readonly ICalculatorStrategy _calculatorStrategy;

        public MathController(ICalculatorStrategy calculatorStrategy)
        {
            _calculatorStrategy = calculatorStrategy;
        }

        [HttpPost]
        public decimal Calculate(decimal a, decimal b, OperatorEnum op)
        {
            return _calculatorStrategy.CalculateMoney(a, b, op);    
        }        
    }
}
