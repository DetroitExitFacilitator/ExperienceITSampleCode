using System;

namespace Abstraction_PayDay
{
    public class SalaryTeamMember : IAmPayable
    {
        private readonly ICalculate _paycheckCalculator;

        public SalaryTeamMember()
        {
            _paycheckCalculator = new PaycheckCalculator();
        }
        
        public void ReceivePayment()
        {
            var amount = _paycheckCalculator.CalculateSalaryPay();
            Console.WriteLine($"Salary Team Member will be paid {amount}");
        }
    }
}