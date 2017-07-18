namespace Abstraction_VroomVroom.Answer
{
    interface IDriveable
    {
        void PressGas(int desiredSpeed);
        void PressBrake(int desiredSpeed);
        void ChangeDirection(int degrees);
    }
}
