using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_VroomVroom
{
    interface IDriveable
    {
        void PressGas(int desiredSpeed);
        void PressBrake(int desiredSpeed);
        void ChangeDirection(int degrees);
    }
}
