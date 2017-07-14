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

        public override void CutCheck()
        {
            var amount = _paycheckCalculator.CalculateCommision();
            Console.WriteLine($"CommissionedTeamMember will be paid {amount}");
        }
    }
}