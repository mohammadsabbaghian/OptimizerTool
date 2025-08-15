using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Models;
using SpeedAlgorithm;
using SpeedAlgorithm.Models;
using System;
using TrainCharacteristicsManager;
using TrainCharacteristicsManager.Models;

namespace SpeedAlgorithm.Testing
{
    [TestClass]
    public class DynamicsHelperTests
    {
        private DynamicsHelper _dynamicsHelper;
        private Constraints _constraints;
        private Dynamics _dynamics;
        private CalcBase _calcBase;
        private SpeedProfile _speedProfile;

        [TestInitialize]
        public void Setup()
        {
            var brakingPowerMap = new PowerMap(new int[0, 0], new float[0], new float[0]);
            var tractionPowerMap = new PowerMap(new int[0, 0], new float[0], new float[0]);
            var brakingCurves = new List<float[]>();
            var regenCurves = new List<float[]>();
            var tractionCurves = new List<float[]>();

            _constraints = new Constraints(100, 1);
            _calcBase = new CalcBase
            {
                algorithmConfiguration = new AlgorithmConfiguration
                {
                    MinimumSpeedAdvice = 5.0f
                },
                Constraints = _constraints,
            };
            var trainCharacteristics = new TrainCharacteristics(brakingPowerMap, tractionPowerMap, brakingCurves, regenCurves, tractionCurves);
            trainCharacteristics.TractionEfficiency = 0.9f;
            trainCharacteristics.RegenEfficiency= 0.9f;

            _dynamics = new Dynamics(_constraints, _calcBase, trainCharacteristics);
            _dynamicsHelper = new DynamicsHelper(_constraints, _dynamics, _calcBase);
            _speedProfile = new SpeedProfile(100);
        }

        [TestMethod]
        public void TestAccelerate()
        {
            // Arrange
            _speedProfile.Speed[0] = 10.0f;
            _speedProfile.Speed[1] = 5.0f;

            // Act
            int result = _dynamicsHelper.Accelerate(_speedProfile, 0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestAccelerateBackwards()
        {
            // Arrange
            _speedProfile.Speed[1] = 10.0f;
            _speedProfile.Speed[0] = 5.0f;

            // Act
            int result = _dynamicsHelper.AccelerateBackwards(_speedProfile, 1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestBrake()
        {
            // Arrange
            _speedProfile.Speed[0] = 10.0f;
            _speedProfile.Speed[1] = 5.0f;

            // Act
            int result = _dynamicsHelper.Brake(_speedProfile, 0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestBrakeBackwards()
        {
            // Arrange
            _speedProfile.Speed[1] = 10.0f;
            _speedProfile.Speed[0] = 5.0f;

            // Act
            int result = _dynamicsHelper.BrakeBackwards(_speedProfile, 1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCoast()
        {
            // Arrange
            _speedProfile.Speed[0] = 10.0f;
            _speedProfile.Speed[1] = 5.0f;

            // Act
            int result = _dynamicsHelper.Coast(_speedProfile, 0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCoastBackwards()
        {
            // Arrange
            _speedProfile.Speed[1] = 10.0f;
            _speedProfile.Speed[0] = 5.0f;

            // Act
            int result = _dynamicsHelper.CoastBackwards(_speedProfile, 1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCruise()
        {
            // Arrange
            _speedProfile.Speed[0] = 10.0f;
            _speedProfile.Speed[1] = 5.0f;

            // Act
            int result = _dynamicsHelper.Cruise(_speedProfile, 0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCruiseBackwards()
        {
            // Arrange
            _speedProfile.Speed[1] = 10.0f;
            _speedProfile.Speed[0] = 5.0f;

            // Act
            int result = _dynamicsHelper.CruiseBackwards(_speedProfile, 1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestRegenerate()
        {
            // Arrange
            _speedProfile.Speed[0] = 10.0f;
            _speedProfile.Speed[1] = 5.0f;

            // Act
            int result = _dynamicsHelper.Regenerate(_speedProfile, 0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestRegenerateBackwards()
        {
            // Arrange
            _speedProfile.Speed[1] = 10.0f;
            _speedProfile.Speed[0] = 5.0f;

            // Act
            int result = _dynamicsHelper.RegenerateBackwards(_speedProfile, 1);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
