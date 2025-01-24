using Shared.Models.Route;
using SpeedOptimizer.Preprocessing;

namespace SpeedOptimizer.Tests
{
    [TestClass]
    public class CurveHelperTests
    {
        [TestMethod]
        public void MergeSegments_ShouldHandleNoOverlap()
        {
            // Arrange
            var curveSegments = new List<CurveSegment>
            {
                new CurveSegment { Start = 0, End = 10, Radius = 100 },
                new CurveSegment { Start = 20, End = 30, Radius = 150 }
            };
            var gradientSegments = new List<GradientSegment>
            {
                new GradientSegment(10, 20, 1),
                new GradientSegment(30, 40, 2)
            };
            var curveHelper = new CurveHelper(1.0f);

            // Act
            var result = curveHelper.MergeSegments(curveSegments, gradientSegments);

            // Assert
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(0, result[0].Start);
            Assert.AreEqual(10, result[0].End);
            Assert.AreEqual(10, result[1].Start);
            Assert.AreEqual(20, result[1].End);
            Assert.AreEqual(1, result[1].Gradient);
            Assert.AreEqual(20, result[2].Start);
            Assert.AreEqual(30, result[2].End);
            Assert.AreEqual(30, result[3].Start);
            Assert.AreEqual(40, result[3].End);
            Assert.AreEqual(2, result[3].Gradient);
        }

        [TestMethod]
        public void MergeSegments_ShouldHandleOverlap()
        {
            // Arrange
            var curveSegments = new List<CurveSegment>
            {
                new CurveSegment { Start = 0, End = 15, Radius = 500 },
                new CurveSegment { Start = 20, End = 50, Radius = 700 }
            };
            var gradientSegments = new List<GradientSegment>
            {
                new GradientSegment(10, 20, 1),
                new GradientSegment(30, 40, 1)
            };
            var curveHelper = new CurveHelper(7.0f);

            // Act
            var result = curveHelper.MergeSegments(curveSegments, gradientSegments);

            // Assert
            Assert.AreEqual(6, result.Count);
            Assert.AreEqual(0, result[0].Start);
            Assert.AreEqual(10, result[0].End)  ;

        }
    }
}

