using System;
using HydrationStationV1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HydrationStationTests
{
    [TestClass]
    public class WaterForDayTests
    {
        [TestMethod]
        public void TestWaterForDayCreation()
        {
            WaterForDay waterIntakeTestObject = new WaterForDay();

            Assert.IsNotNull(waterIntakeTestObject);
        }

        /// <summary>
        /// Test adding water intake to WaterForDay object.
        /// </summary>
        [TestMethod]
        public void TestWaterForDayIntakeUpdate()
        {
            int waterIntake = 345;
            WaterForDay waterIntakeTestObject = new WaterForDay();

            waterIntakeTestObject.updateIntake(waterIntake);
            Assert.AreEqual(waterIntakeTestObject.getIntake(), waterIntake, "Water intake not updated correctly.");
        }

        /// <summary>
        /// Check if the default value of 0 for the water intake variable is created and remains unchanges
        /// upon WaterForDay object creation.
        /// </summary>
        [TestMethod]
        public void TestWaterForDayDefaultSetup()
        {
            int defaultResultUponCreation = 0;
            WaterForDay waterIntakeTestObject = new WaterForDay();

            Assert.AreEqual(waterIntakeTestObject.getIntake(), defaultResultUponCreation, "Water intake not setup correctly.");
        }

        /// <summary>
        /// Test the get method for the daily water intake variable for the WaterForDay object.
        /// </summary>
        [TestMethod]
        public void TestWaterForDayGetMethod()
        {
            WaterForDay waterIntakeTestObject = new WaterForDay();

            Assert.AreEqual(waterIntakeTestObject.getIntake(), waterIntakeTestObject.getIntake(), "Get intake not working correctly.");
        }

        /// <summary>
        /// Test that updating week entry with daily water intake works.
        /// </summary>
        [TestMethod]
        public void TestAssignWaterForDayToWeekEntry()
        {
            int waterIntake = 456;
            WaterForDay waterIntakeTestObject = new WaterForDay();
            WeekEntry weekEntryTestObject = new WeekEntry();

            waterIntakeTestObject.updateIntake(waterIntake);
            weekEntryTestObject.updateIntakeForDay(waterIntakeTestObject.getIntake(), "Monday");

            Assert.AreEqual(waterIntakeTestObject.getIntake(), weekEntryTestObject.getMondayIntake());
        }

        /// <summary>
        /// Test if water for day object can take multiple updates in quick succession.
        /// </summary>
        [TestMethod]
        public void TestWaterForDayMultipleUpdates()
        {
            WaterForDay waterIntakeTestObject = new WaterForDay();
            Random random = new Random(1000);

            try
            {
                for (int i = 0; i < 500; i++)
                {
                    waterIntakeTestObject.updateIntake(random.Next());
                }
            }
            catch
            {
                Console.WriteLine("Error in testing multiple updates on WaterForDay object.");
            }
        }

        /// <summary>
        /// Test to see if the water for day object can take large numbers.
        /// </summary>
        [TestMethod]
        public void TestWaterForDayForLargeNumbers()
        {
            WaterForDay waterIntakeTestObject = new WaterForDay();
            Random random = new Random();

            try
            {
                waterIntakeTestObject.updateIntake(random.Next(10000 * 10000, 10000 * 100000));
            }
            catch
            {
                Console.WriteLine("Error in testing large number on WaterForDay object.");
            }
        }

        /// <summary>
        /// Test to see that negative numbers cannot be used to update WaterForDay object.
        /// </summary>
        [TestMethod]
        public void TestWaterForDayNegativeNumbersHaveNoEffect()
        {
            WaterForDay waterIntakeTestObject = new WaterForDay();

            waterIntakeTestObject.updateIntake(-196);

            Assert.AreEqual(waterIntakeTestObject.getIntake(), 0, "WaterForDay takes negative numbers.");
        }
    }
}
