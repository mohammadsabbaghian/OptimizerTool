using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedOptimizer;
using SpeedOptimizer.Models.Inputs;
using System.Collections.Generic;

namespace SpeedOptimizerTests
{
    [TestClass]
    public class PreProcessorTests
    {
        [TestMethod]
        public void GetWeightedAverageGradientArray_ShouldReturnCorrectValues()
        {
            // Arrange
            var gradientSegments = new List<GradientSegment>
            {
                new GradientSegment(0f,10f, 1f),
                new GradientSegment(10f,20f, 2f),
                new GradientSegment(20f,30f, 3f)
            };
            double interval = 5;
            var ranges = new List<(double start, double end, double weight)>
            {
                (0, 10, 1),
                (10, 20, 1),
                (20, 30, 1)
            };

            // Act
            var result = GradientHelper.GetWeightedAverageGradientArray(gradientSegments, interval, ranges);

            // Assert
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1.5, result[1]);
            Assert.AreEqual(2.5, result[2]);
            Assert.AreEqual(3, result[3]);
        }

        [TestMethod]
        public void GetWeightedAverageGradientArray_ShouldHandleRangesOutsideSegments()
        {
            // Arrange
            var gradientSegments = new List<GradientSegment>
            {
                new GradientSegment(0,10, 1),
                new GradientSegment(10,20, 2)
            };
            double interval = 5;
            var ranges = new List<(double start, double end, double weight)>
            {
                (0, 10, 1),
                (10, 20, 1),
                (20, 30, 1)
            };

            // Act
            var result = GradientHelper.GetWeightedAverageGradientArray(gradientSegments, interval, ranges);

            // Assert
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1.5, result[1]);
            Assert.AreEqual(2, result[2]); 
            Assert.AreEqual(2, result[3]); // Using the last segment's gradient
        }
    }
}