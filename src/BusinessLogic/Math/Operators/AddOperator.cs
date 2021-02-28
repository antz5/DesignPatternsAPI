namespace BusinessLogic.Math.Factory
{
    public class AddOperator : ICalculator
    {
        public OperatorEnum Operator => OperatorEnum.Add;

        public decimal CalculateMoney(decimal a, decimal b)
        {
            return a + b;
        }
    }
}