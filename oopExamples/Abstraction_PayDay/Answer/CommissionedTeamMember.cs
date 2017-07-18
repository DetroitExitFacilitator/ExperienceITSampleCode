using System;

namespace Abstraction_PayDay
{
    public class CommissionedTeamMember : HourlyTeamMember
    {
        private readonly ICalculate _paycheckCalculator;

        public CommissionedTeamMember()
        {
            _paycheckCalculator = new PaycheckCalculator();
        }

        public override void ReceivePayment()
        {
            var amount = _paycheckCalculator.CalculateCommisionPay();
            Console.WriteLine($"Commissioned Team Member will be paid {amount}");
        }
    }
}