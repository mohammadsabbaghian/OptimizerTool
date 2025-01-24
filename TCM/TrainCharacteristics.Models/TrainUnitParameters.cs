using Shared.Models.Timetable;
using Shared.Models.Train;

namespace TrainCharacteristicsManager.Models
{
    public class TrainUnitParameters
    {
        public string PartitionKey => "TrainUnitParameters";

        public string Class { get; set; }
        public string BaseClassType { get; set; }
        public float CurveRes { get; set; }
        public float Mass { get; set; }
        public float Length { get; set; }
        public float DragA { get; set; }
        public float DragAmass { get; set; }
        public float DragB { get; set; }
        public float DragBmass { get; set; }
        public float DragC { get; set; }
        public float DeltaDragC { get; set; }
        public float MaxSpeed { get; set; }
        public float RotatingMassCoefficient { get; set; }
        public int NumberOfCars { get; set; }
        public float MechanicalBraking { get; set; }
        public TrafficType Type { get; set; }
        public Propulsion Propulsion { get; set; }
        public ProtectionSystem[] ProtectionSystem { get; set; }

        //For train where we have the model
        public PowerMap TractionPowerMap { get; set; }
        public PowerMap BrakingPowerMap { get; set; }
        public List<ForceCurve> BrakingCurves { get; set; }
        public List<ForceCurve> TractionCurves { get; set; }

        //For train where we don't have the full curve or map.
        public float BrakingForce { get; set; }
        public float BrakingPower { get; set; }
        public int TractionForce { get; set; }
        public int TractionPower { get; set; }
        public float TractionEfficiency { get; set; }
        public float BrakingEfficiency { get; set; }
    }
}
