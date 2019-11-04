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
    }
}
