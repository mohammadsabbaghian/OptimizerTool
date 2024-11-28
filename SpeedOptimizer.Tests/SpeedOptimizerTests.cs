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
                new GradientSegment { Start = 0, End = 10, Gradient = 1 },
                new GradientSegment { Start = 10, End = 20, Gradient = 2 },
                new GradientSegment { Start = 20, End = 30, Gradient = 3 }
            };
            double interval = 5;
            var ranges = new List<(double start, double end, double weight)>
            {
                (0, 10, 1),
                (10, 20, 1),
                (20, 30, 1)
            };
            var preProcessor = new PreProcessor();

            // Act
            var result = preProcessor.GetWeightedAverageGradientArray(gradientSegments, interval, ranges);

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
                new GradientSegment { Start = 0, End = 10, Gradient = 1 },
                new GradientSegment { Start = 10, End = 20, Gradient = 2 }
            };
            double interval = 5;
            var ranges = new List<(double start, double end, double weight)>
            {
                (0, 10, 1),
                (10, 20, 1),
                (20, 30, 1)
            };
            var preProcessor = new PreProcessor();

            // Act
            var result = preProcessor.GetWeightedAverageGradientArray(gradientSegments, interval, ranges);

            // Assert
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1.5, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(2, result[3]); // Using the last segment's gradient
        }
    }
}