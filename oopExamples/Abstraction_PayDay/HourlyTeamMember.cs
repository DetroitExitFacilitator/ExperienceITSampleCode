using System;

namespace Abstraction_PayDay
{
    public class HourlyTeamMember : IPayable 
    {
        private readonly ICalculate _paycheckCalculator;

        public HourlyTeamMember()
        {
            _paycheckCalculator = new PaycheckCalculator();
        }
        
        public virtual void CutCheck()
        {
            var amount = _paycheckCalculator.CalculateHourly();
            Console.WriteLine($"HourlyTeamMember will be paid {amount}");
        }
    }
}