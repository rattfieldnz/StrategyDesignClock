using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyClock
{
    public partial class Form1 : Form
    {
        DigitalClock digitalClock;
        AnalogueClock analogueClock;

        int clickCount;
        public Form1()
        {
            InitializeComponent();
            this.digitalClock = new DigitalClock(timeLabel);
            this.analogueClock = new AnalogueClock(analogClock);
            this.clickCount = 1;
        }

        private void turnClockOnBTN_Click(object sender, EventArgs e)
        {
            clickCount++;
            turnClockOnBTN.Text = "Turn Clock Off";

            analogClock.Visible = false;
            timeLabel.Visible = false;

            if (clickCount % 2 == 0)
            {
                if (analogueClockRB.Checked)
                {
                    digitalClock.clockOff();
                    timeLabel.Visible = false;
                    analogClock.Visible = true;
                }
                else if (digitalClockRB.Checked)
                {
                    analogClock.Visible = false;
                    digitalClock.clockOn();

                    timeLabel.Visible = true;
                }
            }
            else
            {
                turnClockOnBTN.Text = "Turn Clock On";

                timeLabel.Visible = false;
                analogClock.Visible = false;
            }
        }

        private void digitalClockRB_CheckedChanged(object sender, EventArgs e)
        {
            if (clickCount % 2 == 0)
            {
                analogClock.Visible = false;
                timeLabel.Visible = true;
            }
        }

        private void analogueClockRB_CheckedChanged(object sender, EventArgs e)
        {
            if (clickCount % 2 == 0)
            {
                timeLabel.Visible = false;
                analogClock.Visible = true;
            }
        }


    }
}
