using System;

namespace Abstraction_PayDay
{
    public class HourlyTeamMember : IAmPayable 
    {
        private readonly ICalculate _paycheckCalculator;

        public HourlyTeamMember()
        {
            _paycheckCalculator = new PaycheckCalculator();
        }
        
        public virtual void ReceivePayment()
        {
            var amount = _paycheckCalculator.CalculateHourlyPay();
            Console.WriteLine($"Hourly Team Member will be paid {amount}");
        }
    }
}