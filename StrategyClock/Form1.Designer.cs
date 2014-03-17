namespace StrategyClock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clockTypesGroup = new System.Windows.Forms.GroupBox();
            this.analogueClockRB = new System.Windows.Forms.RadioButton();
            this.digitalClockRB = new System.Windows.Forms.RadioButton();
            this.turnClockOnBTN = new System.Windows.Forms.Button();
            this.analogClock = new AnalogClockControl.AnalogClock();
            this.timeLabel = new System.Windows.Forms.Label();
            this.clockTypesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockTypesGroup
            // 
            this.clockTypesGroup.Controls.Add(this.analogueClockRB);
            this.clockTypesGroup.Controls.Add(this.digitalClockRB);
            this.clockTypesGroup.Font = new System.Drawing.Font("Magneto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockTypesGroup.Location = new System.Drawing.Point(14, 12);
            this.clockTypesGroup.Name = "clockTypesGroup";
            this.clockTypesGroup.Size = new System.Drawing.Size(313, 196);
            this.clockTypesGroup.TabIndex = 0;
            this.clockTypesGroup.TabStop = false;
            this.clockTypesGroup.Text = "Clock Types";
            // 
            // analogueClockRB
            // 
            this.analogueClockRB.AutoSize = true;
            this.analogueClockRB.Font = new System.Drawing.Font("Magneto", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogueClockRB.Location = new System.Drawing.Point(18, 131);
            this.analogueClockRB.Name = "analogueClockRB";
            this.analogueClockRB.Size = new System.Drawing.Size(208, 45);
            this.analogueClockRB.TabIndex = 1;
            this.analogueClockRB.Text = "Analogue";
            this.analogueClockRB.UseVisualStyleBackColor = true;
            this.analogueClockRB.CheckedChanged += new System.EventHandler(this.analogueClockRB_CheckedChanged);
            // 
            // digitalClockRB
            // 
            this.digitalClockRB.AutoSize = true;
            this.digitalClockRB.Font = new System.Drawing.Font("Magneto", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClockRB.Location = new System.Drawing.Point(18, 79);
            this.digitalClockRB.Name = "digitalClockRB";
            this.digitalClockRB.Size = new System.Drawing.Size(157, 45);
            this.digitalClockRB.TabIndex = 0;
            this.digitalClockRB.Text = "Digital";
            this.digitalClockRB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.digitalClockRB.UseVisualStyleBackColor = true;
            this.digitalClockRB.CheckedChanged += new System.EventHandler(this.digitalClockRB_CheckedChanged);
            // 
            // turnClockOnBTN
            // 
            this.turnClockOnBTN.Font = new System.Drawing.Font("Magneto", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnClockOnBTN.Location = new System.Drawing.Point(502, 12);
            this.turnClockOnBTN.Name = "turnClockOnBTN";
            this.turnClockOnBTN.Size = new System.Drawing.Size(430, 48);
            this.turnClockOnBTN.TabIndex = 1;
            this.turnClockOnBTN.Text = "Turn Clock On";
            this.turnClockOnBTN.UseVisualStyleBackColor = true;
            this.turnClockOnBTN.Click += new System.EventHandler(this.turnClockOnBTN_Click);
            // 
            // analogClock
            // 
            this.analogClock.Draw1MinuteTicks = true;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock.Location = new System.Drawing.Point(505, 66);
            this.analogClock.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock.Name = "analogClock";
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(422, 422);
            this.analogClock.TabIndex = 2;
            this.analogClock.TicksColor = System.Drawing.Color.Black;
            this.analogClock.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Magneto", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(500, 200);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 81);
            this.timeLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 496);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.analogClock);
            this.Controls.Add(this.turnClockOnBTN);
            this.Controls.Add(this.clockTypesGroup);
            this.Name = "Form1";
            this.Text = "StrategyDesignClock";
            this.clockTypesGroup.ResumeLayout(false);
            this.clockTypesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox clockTypesGroup;
        private System.Windows.Forms.RadioButton analogueClockRB;
        private System.Windows.Forms.RadioButton digitalClockRB;
        private System.Windows.Forms.Button turnClockOnBTN;
        private AnalogClockControl.AnalogClock analogClock;
        private System.Windows.Forms.Label timeLabel;
    }
}

