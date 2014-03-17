using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyClock
{
    /// <summary>
    /// This class is responsible for implementing
    /// an analogue clock, via a 3rd-party dll
    /// (AnalogClockControl.dll) located in the 
    /// Debug and Release folders.
    /// </summary>
    class AnalogueClock:IClock
    {
        /// <summary>
        /// Declaring the analogue clock to use.
        /// </summary>
        AnalogClockControl.AnalogClock analogueClock;

        /// <summary>
        /// Main constructor - responsible for creating the analogue clock.
        /// </summary>
        /// <param name="analogueClock">The analogue clock (provided by AnalogClockControl.dll)</param>
        public AnalogueClock(AnalogClockControl.AnalogClock analogueClock)
        {
            ///<summary>
            ///Initialise the analogue clock.
            this.analogueClock = analogueClock;
        }

        /// <summary>
        /// This method turns the analogue clock "on" 
        /// by making the clock visible on the form.
        /// </summary>
        public void clockOn()
        {
            this.analogueClock.Visible = true;
        }

        /// <summary>
        /// This method turns the analogue clock "off" 
        /// by making the clock not visible on the form.
        /// </summary>
        public void clockOff()
        {
            this.analogueClock.Visible = false;
        }
    }
}
