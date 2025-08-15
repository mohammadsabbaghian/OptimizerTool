using Shared.Models.Route;
using Shared.Models.Timetable;
using TrainCharacteristicsManager;

public interface ISferaMessageHandler
{
    /// <summary>
    /// Deserializes the XML file into a version-specific ISferaMessage.
    /// </summary>
    ISferaMessage Deserialize(string filePath);

    /// <summary>
    /// Validates the segment profiles against the journey profile.
    /// </summary>
    void ValidateSegmentProfiles(ISferaMessage jpMessage, ISferaMessage spMessage);

    /// <summary>
    /// Maps the version-specific models into common domain models.
    /// </summary>
    //(TimeConstraints, RouteConstraints) MapProfiles(ISferaMessage jpMessage, ISferaMessage spMessage);
    
    (TimeConstraints, RouteConstraints) MapProfiles(ISferaMessage jpMessage, ISferaMessage spMessage, ITrainCharacteristics trainCharacteristics);
}