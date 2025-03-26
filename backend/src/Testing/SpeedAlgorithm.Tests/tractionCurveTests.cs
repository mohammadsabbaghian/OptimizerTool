using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TrainCharacteristicsManager;
using TrainCharacteristicsManager.Models;

namespace SpeedAlgorithm.Tests
{
    [TestClass]
    public class tractionCurveTests
    {
        public TestContext TestContext { get; set; } 

        [TestMethod]
        public void TestTractionForePerformance()
        {
            // Create dummy data
            var tractionCurves = new List<float[]>
            {
                new float[200],
                new float[200]
            };

            var brakingCurves = new List<float[]>
            {
                new float[200],
                new float[200]
            };

            var regenCurves = new List<float[]>
            {
                new float[200],
                new float[200]
            };

            var speeds = new float[200];
            var powers = new int[200, 200];
            var tractionPercentages = new float[200];

            var tractionPowerMap = new PowerMap(powers, speeds, tractionPercentages);
            var brakingPowerMap = new PowerMap(powers, speeds, tractionPercentages);

            var trainCharacteristics = new TrainCharacteristics(tractionPowerMap, brakingPowerMap, tractionCurves, brakingCurves, regenCurves);

            // Fill dummy data with random values
            var random = new Random();
            for (int i = 0; i < 200; i++)
            {
                speeds[i] = (float)random.NextDouble() * 100;
                tractionPercentages[i] = (float)random.NextDouble() * 100;
                for (int j = 0; j < 200; j++)
                {
                    powers[i, j] = random.Next(0, 1000);
                    tractionCurves[0][j] = (float)random.NextDouble() * 1000;
                    tractionCurves[1][j] = (float)random.NextDouble() * 1000;
                    brakingCurves[0][j] = (float)random.NextDouble() * 1000;
                    brakingCurves[1][j] = (float)random.NextDouble() * 1000;
                }
            }

            // Create an array of random speeds between 0 and 60
            var speedArray = new float[100000000];
            for (int i = 0; i < speedArray.Length; i++)
            {
                speedArray[i] = (float)random.NextDouble() * 60;
            }

            int curveIndex = 0;

            var stopwatch = new Stopwatch();

            stopwatch.Restart();
            for (int i = 0; i < speedArray.Length; i++)
            {
                trainCharacteristics.GetTractionFore(speedArray[i], curveIndex);
            }
            stopwatch.Stop();
            var timeGetTractionFore2 = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();
            for (int i = 0; i < speedArray.Length; i++)
            {
                trainCharacteristics.GetTractionFore(speedArray[i], curveIndex);
            }
            stopwatch.Stop();
            var timeGetTractionFore = stopwatch.ElapsedMilliseconds;



            // Output the results to the TestContext
            TestContext.WriteLine($"GetTractionFore: {timeGetTractionFore} ms");
            TestContext.WriteLine($"GetTractionFore2: {timeGetTractionFore2} ms");

        }
    }
}