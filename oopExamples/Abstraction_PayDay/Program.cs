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
            //We have 3 different team members who all get paid on Friday
            //But they all get paid differently based on what they did.
            IPayable hourlyTeamMember = new HourlyTeamMember();
            IPayable commisionedTeamMember = new CommissionedTeamMember();
            IPayable salaryTeamMember = new SalaryTeamMember();

            //Create a way for our Check Cutting program to pay all these people without
            //having to specifically know how they get paid
            hourlyTeamMember.CutCheck();
            commisionedTeamMember.CutCheck();
            salaryTeamMember.CutCheck();

            Console.ReadLine();
        }

        public static void CutChecksPolymorphically()
        {
            List<IPayable> payableEntities = new List<IPayable>
            {
                new HourlyTeamMember(),
                new CommissionedTeamMember(),
                new SalaryTeamMember()
            };

            foreach (var entity in payableEntities)
            {
                entity.CutCheck();
            }
        }
    }
}
