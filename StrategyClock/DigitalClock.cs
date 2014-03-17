using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace StrategyClock
{
    /// <summary>
    /// This class is responsible for creating a digital clock, 
    /// implementing common behaviours from the IClock Interface.
    /// </summary>
    class DigitalClock:IClock
    {
        /// <summary>
        /// Declare the label where the digital time will be displayed, 
        /// and the timer which the digital clock will use.
        /// </summary>
        private System.Windows.Forms.Label displayDigitalTime;
        private System.Windows.Forms.Timer timer;

        /// <summary>
        /// Main constructor - takes in the label where the clock time
        /// will be displayed. Initialises the data to be used in creating 
        /// the clock.
        /// </summary>
        /// <param name="displayDigitalTime">The label to display the clock's time.</param>
        public DigitalClock(System.Windows.Forms.Label displayDigitalTime)
        {
            ///<summary>
            ///Initialise the display label
            ///</summary>
            this.displayDigitalTime = displayDigitalTime;

            ///<summary>
            ///Initialise the clock's timer
            ///</summary>
            this.timer = new System.Windows.Forms.Timer();

            ///<summary>
            ///Set the interval for the timer (every 1 second)
            ///</summary>
            timer.Interval = 1000;

            ///<summary>
            ///Using a delegate - passing in the function 
            ///responsible for creating the time, and call that
            ///function every second, creating a new time on 
            ///each timer tick.
            ///</summary>
            timer.Tick += new EventHandler(updateTimeDisplay);
        }

        /// <summary>
        /// This method turns on the clock by 
        /// starting it's timer, while also 
        /// setting it's label display 
        /// visibility to true.
        /// </summary>
        public void clockOn()
        {
            this.timer.Start();
            displayDigitalTime.Visible = true;
        }

        /// <summary>
        /// This method turns off the clock by 
        /// stopping it's timer, while also 
        /// setting it's label display 
        /// visibility to false.
        /// </summary>
        public void clockOff()
        {
            this.timer.Stop();
            displayDigitalTime.Visible = false;
        }

        /// <summary>
        /// This function is used to create a time, 
        /// and is used in a delegate function call 
        /// to update the time every 1 second.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event handler</param>
        public void updateTimeDisplay(object sender, EventArgs e)
        {
            displayDigitalTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
