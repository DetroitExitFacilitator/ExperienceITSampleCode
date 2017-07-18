using System;
using System.Collections.Generic;

namespace Abstraction_PayDay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CutChecks();
        }

        public static void CutChecks()
        {
            // We have 3 different team members who all get paid on Friday
            // But they all get paid differently based on what they did.
            IAmPayable hourlyTeamMember = new HourlyTeamMember();
            IAmPayable commisionedTeamMember = new CommissionedTeamMember();
            IAmPayable salaryTeamMember = new SalaryTeamMember();

            // Use abstraction to create a way for our Check Cutting program to pay all these people without
            // having to specifically know how they get paid
            hourlyTeamMember.ReceivePayment();
            commisionedTeamMember.ReceivePayment();
            salaryTeamMember.ReceivePayment();

            Console.ReadLine();
        }

        public static void CutChecksPolymorphically()
        {
            List<IAmPayable> payableEntities = new List<IAmPayable>
            {
                new HourlyTeamMember(),
                new CommissionedTeamMember(),
                new SalaryTeamMember()
            };

            foreach (IAmPayable entity in payableEntities)
            {
                entity.ReceivePayment();
            }
        }
    }
}
