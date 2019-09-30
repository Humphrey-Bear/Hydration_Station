using System;
using System.Collections.Generic;
using System.Text;

namespace HydrationStationV1.Models
{
    public class WaterForDay
    {
        public int intakeForDay;

        //Creates the volume of water consumed for the day.
        public WaterForDay() {
            this.intakeForDay = 0;
        }

        //Updates the intake for the day.
        public void updateIntake(int volumeToAdd) {
            intakeForDay += volumeToAdd;
        }

        //Returns the volume of water consumed for day.
        public int getIntake() {
            return intakeForDay;
        }

    }
}
