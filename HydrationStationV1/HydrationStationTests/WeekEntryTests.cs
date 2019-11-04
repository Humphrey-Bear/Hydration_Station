using HydrationStationV1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HydrationStationTests
{
    [TestClass]
    public class WeekEntryTests
    {
        [TestMethod]
        public void TestWeekEntryCreation()
        {
            WeekEntry weekEntryTestObject = new WeekEntry();

            Assert.IsNotNull(weekEntryTestObject);
        }

        [TestMethod]
        public void TestWeekEntryForMonday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Monday");
            Assert.AreEqual(weekEntryTestObject.getMondayIntake(), weekEntryIntake, "Week entry did not work for Monday.");
        }

        [TestMethod]
        public void TestWeekEntryForTuesday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Tuesday");
            Assert.AreEqual(weekEntryTestObject.getTuesdayIntake(), weekEntryIntake, "Week entry did not work for Tuesday.");
        }

        [TestMethod]
        public void TestWeekEntryForWednesday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Wednesday");
            Assert.AreEqual(weekEntryTestObject.getWednesdayIntake(), weekEntryIntake, "Week entry did not work for Wednesday.");
        }

        [TestMethod]
        public void TestWeekEntryForThursday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Thursday");
            Assert.AreEqual(weekEntryTestObject.getThursdayIntake(), weekEntryIntake, "Week entry did not work for Thursday.");
        }

        [TestMethod]
        public void TestWeekEntryForFriday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Friday");
            Assert.AreEqual(weekEntryTestObject.getFridayIntake(), weekEntryIntake, "Week entry did not work for Friday.");
        }

        [TestMethod]
        public void TestWeekEntryForSaturday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Saturday");
            Assert.AreEqual(weekEntryTestObject.getSaturdayIntake(), weekEntryIntake, "Week entry did not work for Saturday.");
        }

        [TestMethod]
        public void TestWeekEntryForSunday()
        {
            int weekEntryIntake = 345;
            WeekEntry weekEntryTestObject = new WeekEntry();

            weekEntryTestObject.updateIntakeForDay(weekEntryIntake, "Sunday");
            Assert.AreEqual(weekEntryTestObject.getSundayIntake(), weekEntryIntake, "Week entry did not work for Sunday.");
        }

        [TestMethod]
        public void TestWaterForDayAddedToWeek()
        {
            int waterForDay = 567;
            WaterForDay waterForDayTestObject = new WaterForDay();
            WeekEntry weekEntryTestObject = new WeekEntry();

            waterForDayTestObject.updateIntake(waterForDay);
            weekEntryTestObject.updateIntakeForDay(waterForDayTestObject.getIntake(), "Monday");

            Assert.AreEqual(waterForDay, weekEntryTestObject.getMondayIntake(), "Water for day not added to week properly.");
        }
    }
}
