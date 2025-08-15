using Shared.Models.Route;
using Shared.Models.Timetable;
using System.Xml.Serialization;
using SFERA_v3_00;
using SferaHandlers.v3;
using TrainCharacteristicsManager;

public class SferaMessageHandler_v3_00 : ISferaMessageHandler
{
    private JourneyProfile _cachedJourneyProfile;
    private SegmentProfile[] _cachedSegmentProfiles;

    public ISferaMessage Deserialize(string filePath)
    {
        // Reset caches when deserializing a new file
        _cachedJourneyProfile = null;
        _cachedSegmentProfiles = null;

        XmlSerializer serializer = new XmlSerializer(typeof(SFERA_v3_00.SFERA_G2B_ReplyMessage));
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            return serializer.Deserialize(fileStream) as ISferaMessage
                ?? throw new InvalidOperationException("Failed to deserialize SFERA_v3_00 message.");
        }
    }
    private void ExtractPayload(ISferaMessage jpMessage, ISferaMessage spMessage)
    {
        if (_cachedJourneyProfile != null && _cachedSegmentProfiles != null)
        {
            // Payloads already extracted, no need to do it again
            return;
        }

        // Extract JP payload
        if (jpMessage is SFERA_G2B_ReplyMessage jpReplyMessage)
        {
            var jpPayload = jpReplyMessage.Item as G2B_ReplyPayload;
            if (jpPayload == null)
            {
                throw new InvalidOperationException("Failed to extract JourneyProfile payload from SFERA_v3_00 message.");
            }

            _cachedJourneyProfile = jpPayload.JourneyProfile?.FirstOrDefault();
            _cachedSegmentProfiles = jpPayload.SegmentProfile; // Use SPs from JP if available
        }
        else if (jpMessage is SFERA_G2B_EventMessage jpEventMessage)
        {
            var jpPayload = jpEventMessage.G2B_EventPayload.Items.OfType<JourneyProfile>().FirstOrDefault();
            if (jpPayload == null)
            {
                throw new InvalidOperationException("Failed to extract JourneyProfile payload from SFERA_v3_00 event message.");
            }

            _cachedJourneyProfile = jpPayload;
            _cachedSegmentProfiles = null; // No SPs in this case
        }
        else
        {
            throw new InvalidOperationException("Unsupported JP message type for SFERA_v3_00.");
        }

        // Extract SP payload if provided
        if (spMessage != null)
        {
            if (spMessage is SFERA_G2B_ReplyMessage spReplyMessage)
            {
                var spPayload = spReplyMessage.Item as G2B_ReplyPayload;
                if (spPayload == null)
                {
                    throw new InvalidOperationException("Failed to extract SegmentProfile payload from SFERA_v3_00 message.");
                }

                _cachedSegmentProfiles = spPayload.SegmentProfile; // Override SPs if provided separately
            }
            else
            {
                throw new InvalidOperationException("Unsupported SP message type for SFERA_v3_00.");
            }
        }
    }
    public void ValidateSegmentProfiles(ISferaMessage jpMessage, ISferaMessage spMessage)
    {
        ExtractPayload(jpMessage, spMessage);

        if (_cachedJourneyProfile == null)
        {
            throw new InvalidOperationException("JourneyProfile is missing in the message.");
        }

        if (_cachedSegmentProfiles == null)
        {
            throw new InvalidOperationException("SegmentProfiles are missing in the message.");
        }

        foreach (var sp in _cachedJourneyProfile.SegmentProfileReference)
        {
            if (_cachedSegmentProfiles.FirstOrDefault(x => x.SP_ID == sp.SP_ID) == null)
            {
                throw new Exception("Not all segment profiles delivered.");
            }
        }
    }
    public (TimeConstraints, RouteConstraints) MapProfiles(ISferaMessage jpMessage, ISferaMessage spMessage, ITrainCharacteristics traincharacteristics)
    {
        ExtractPayload(jpMessage, spMessage);

        ValidateSegmentProfiles(jpMessage, spMessage);

        if (_cachedJourneyProfile == null)
        {
            throw new InvalidOperationException("JourneyProfile is missing in the message.");
        }

        // Map version-specific models to common domain models
        var jpMapper = new JpMapper_v3_00();
        var timeConstraints = jpMapper.Map(_cachedJourneyProfile, _cachedSegmentProfiles);

        var spMapper = new SpMapper_v3_00();
        var routeConstraints = spMapper.Map(_cachedJourneyProfile, _cachedSegmentProfiles, traincharacteristics);

        return (timeConstraints, routeConstraints);
    }
}