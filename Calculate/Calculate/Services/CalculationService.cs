using Calculate.Services.Interface;

namespace Calculate.Services
{
    internal class CalculationService : ICalculationService
    {
        public decimal Calculate(decimal num1, string operation, decimal num2)
        {
            decimal result;

            switch (operation)
            {
                case "+":

                    result=num1 + num2; 
                    return result;
                    break;


                case "-":

                    result = num1 - num2;
                    return result;
                    break;


                case "/":

                    result = num1 / num2;
                    return result;
                    break;


                case "*":

                    result = num1 * num2;
                    return result;
                    break;
            }

            return 0;
        }
    }
}
