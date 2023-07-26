namespace Calculate.Services.Interface
{
    internal interface ICalculationService
    {
        decimal Calculate(decimal num1, string operation, decimal num2);
    }
}
