namespace Polymorphism_PowerRangers
{
    public interface IRanger
    {
        string RangerName { get; set; }
        string Zord { get; set; }
        void YellName();
        void Morph();
    }
}