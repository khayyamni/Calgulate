using Calculate.Services;
using Calculate.Services.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Controller
{
    internal class CalculateController
    {
        private readonly ICalculationService _calculationService;
        public CalculateController()
        {
            _calculationService = new CalculationService();

        }

        public void Calculate()
        {
            Console.WriteLine("Add number: ");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Add Operation: ");
            string operation = Console.ReadLine();

            Console.WriteLine("Add number:");
            decimal b = decimal.Parse(Console.ReadLine());



            Console.WriteLine(_calculationService.Calculate(a, operation, b));
        }



    }
}
