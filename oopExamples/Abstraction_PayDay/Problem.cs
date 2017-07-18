namespace Abstraction_PayDay
{
    public class Problem
    {
        // We have 3 different team members who all get paid on Friday
        // But they all get paid differently based on what they did.

        // You will be creating a HourlyTeamMember, SalaryTeamMember, and CommisionedTeamMember class
        // Use an interface called IAmPayable to provide a method for all TeamMembers to ReceivePayment( )
        // ReceivePayment should display the amount they will be paid (Ex: "CommissionedTeamMember will be paid {amount}") the amount can be a string

        // CommisionedTeamMember inherits from HourlyTeamMember

        // Use abstraction to create a way for our Check Cutting program to pay all these people without
        // having to specifically know how they get paid

        // Once that is done, create an instance of each team member and call their ReceivePayment method 
    }
}