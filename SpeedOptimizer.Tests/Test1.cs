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
            double[] speeds = { 0, 0.5,1, 2, 4};
            double[] tractionPercentages = { 0, 0.5, 1, 2, 6};

            // Act
            PowerMap powerMap = new PowerMap(powers, speeds, tractionPercentages);

            // Assert
            Assert.AreEqual(100, powerMap.Map[0, 0]);
            Assert.AreEqual(900, powerMap.Map[1, 1]);
            Assert.AreEqual(0, powerMap.Map[2, 2]);
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
            double[] speeds = { 0, 1, 2 };
            double[] tractionPercentages = { 0, 1, 2 };

            // Act
            PowerMap powerMap = new PowerMap(powers, speeds, tractionPercentages);

            // Assert
            Assert.AreEqual(150, powerMap.Map[0, 1]); // Interpolated value between 100 and 200
            Assert.AreEqual(650, powerMap.Map[2, 1]); // Interpolated value between 600 and 700
        }

        [TestMethod]
        public void PowerMap_OutOfBounds_ThrowsArgumentException()
        {
            // Arrange
            int[,] powers = {
                { 100, 200, 300 },
                { 400, 500, 600 },
                { 700, 800, 900 }
            };
            double[] speeds = { 0, 1, 2 };
            double[] tractionPercentages = { 0, 1, 2 };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new PowerMap(powers, new double[] { -1, 1, 2 }, tractionPercentages));
            Assert.ThrowsException<ArgumentException>(() => new PowerMap(powers, speeds, new double[] { -1, 1, 2 }));
        }
    }
}