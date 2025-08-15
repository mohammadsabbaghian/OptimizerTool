using Shared.Models;
using TrainCharacteristicsManager;

public class OptimizerProject
{
    public object JourneyProfile { get; set; }
    public object SegmentProfiles { get; set; }
    public AlgorithmConfiguration AlgorithmConfiguration { get; set; }
    public object TrainCharacteristics { get; set; }
    public string SferaVersion { get; set; } 
    public string Name { get; set; }
    public DateTime SavedAt { get; set; }
    public string TrainNumber { get; internal set; }
}