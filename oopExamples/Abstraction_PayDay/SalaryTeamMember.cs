using System;

namespace Abstraction_PayDay
{
    public class SalaryTeamMember : IPayable
    {
        private readonly ICalculate _paycheckCalculator;

        public SalaryTeamMember()
        {
            _paycheckCalculator = new PaycheckCalculator();
        }
        
        public void CutCheck()
        {
            var amount = _paycheckCalculator.CalculateSalary();
            Console.WriteLine($"SalaryTeamMember will be paid {amount}");
        }
    }
}