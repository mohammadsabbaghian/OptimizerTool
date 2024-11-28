using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedOptimizer.Models.Inputs;
using System;

namespace SpeedOptimizer.Tests
{
    [TestClass]
    public class PowerMapTests
    {
        [TestMethod]
        public void PowerMap_ExactMatch_ReturnsCorrectValue()
        {
            // Arrange
            int[,] powers = {
                { 100, 200, 300, 250, 300 },
                { 400, 500, 600, -100, -200 },
                { 700, 800, 900, -100, 100 },
                { 700, 800, 900, 0, 5 },
                { 700, 800, 900, 2, -2 }
            };
            float[] speeds = { 0, 0.5f,1, 2, 4};
            float[] tractionPercentages = { 0, 0.5f, 1, 2, 6};

            // Act
            PowerMap powerMap = new PowerMap(powers, speeds, tractionPercentages);

            // Assert
            Assert.AreEqual(100, powerMap.Powers[0, 0]);
            Assert.AreEqual(900, powerMap.Powers[1, 1]);
            Assert.AreEqual(0, powerMap.Powers[2, 2]);
        }

        [TestMethod]
        public void PowerMap_Interpolation_ReturnsInterpolatedValue()
        {
            // Arrange
            int[,] powers = {
                { 100, 200, 300 },
                { 400, 500, 600 },
                { 700, 800, 900 }
            };
            float[] speeds = { 0, 2, 3 };
            float[] tractionPercentages = { 0, 2, 3 };

            // Act
            PowerMap powerMap = new PowerMap(powers, speeds, tractionPercentages);

            // Assert
            Assert.AreEqual(150, powerMap.Powers[0, 1]); // Interpolated value between 100 and 200
            Assert.AreEqual(300, powerMap.Powers[1, 1]); // Interpolated value between 100, 200, 400 and 500
        }
    }
}