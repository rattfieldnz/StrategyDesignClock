using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyClock
{
    /// <summary>
    /// This is the interface showing common
    /// behaviours of a clock.
    /// </summary>
    interface IClock
    {
        //Turning a clock on.
        void clockOn();

        //Turning a clock off.
        void clockOff();
    }
}
