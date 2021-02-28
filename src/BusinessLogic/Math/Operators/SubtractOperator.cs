namespace BusinessLogic.Math.Factory
{
    public class SubtractOperator : ICalculator
    {
        public OperatorEnum Operator => OperatorEnum.Subtract;

        public decimal CalculateMoney(decimal left, decimal right)
        {
            return left - right;
        }
    }
}