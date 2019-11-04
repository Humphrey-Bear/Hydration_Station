using System;
namespace HydrationStationV1.Models
{

    public class WeekEntry
    {
        int weeklyIntake;

        int mondayIntake;
        int tuesdayIntake;
        int wednesdayIntake;
        int thursdayIntake;
        int fridayIntake;
        int saturdayIntake;
        int sundayIntake;

        /// <summary>
        /// Constructs an entry for the week which the bar graph will be
        /// made from.
        /// </summary>
        public WeekEntry()
        {
            this.mondayIntake = 0;
        }

        /// <summary>
        /// Updates the intake for specific day.
        /// </summary>
        /// <param name="intakeForDay">The amount of water consumed
        /// for that day.</param>
        /// <param name="day">The day to record the intake for. Must be the full
        /// name of the day in lower case i.e. "monday"</param>
        public void updateIntakeForDay(int intakeForDay, string day)
        {

            switch (day)
            {
                case "Monday":
                    mondayIntake = intakeForDay;
                    break;
                case "Tuesday":
                    tuesdayIntake = intakeForDay;
                    break;
                case "Wednesday":
                    wednesdayIntake = intakeForDay;
                    break;
                case "Thursday":
                    thursdayIntake = intakeForDay;
                    break;
                case "Friday":
                    fridayIntake = intakeForDay;
                    break;
                case "Saturday":
                    saturdayIntake = intakeForDay;
                    break;
                case "Sunday":
                    sundayIntake = intakeForDay;
                    break;
            }
        }

        /// <summary>
        /// Gets the intake for the entire week.
        /// </summary>
        /// <returns>The week's water intake.</returns>
        public int getWeeklyIntake()
        {
            return weeklyIntake;
        }

        /// <summary>
        /// Gets the intake for Monday.
        /// </summary>
        /// <returns>Monday's water intake.</returns>
        public int getMondayIntake()
        {
            return mondayIntake;
        }

        /// <summary>
        /// Gets the intake for Tuesday.
        /// </summary>
        /// <returns>Tuesday's water intake.</returns>
        public int getTuesdayIntake()
        {
            return tuesdayIntake;
        }

        /// <summary>
        /// Gets the intake for Wednesday.
        /// </summary>
        /// <returns>Wednesday's water intake.</returns>
        public int getWednesdayIntake()
        {
            return wednesdayIntake;
        }

        /// <summary>
        /// Gets the intake for Thursday.
        /// </summary>
        /// <returns>Thursday's water intake.</returns>
        public int getThursdayIntake()
        {
            return thursdayIntake;
        }

        /// <summary>
        /// Gets the intake for Friday.
        /// </summary>
        /// <returns>Friday's water intake.</returns>
        public int getFridayIntake()
        {
            return fridayIntake;
        }

        /// <summary>
        /// Gets the intake for Saturday.
        /// </summary>
        /// <returns>Saturday's water intake.</returns>
        public int getSaturdayIntake()
        {
            return saturdayIntake;
        }

        /// <summary>
        /// Gets the intake for Sunday.
        /// </summary>
        /// <returns>Sunday's water intake.</returns>
        public int getSundayIntake()
        {
            return sundayIntake;
        }
    }
}
