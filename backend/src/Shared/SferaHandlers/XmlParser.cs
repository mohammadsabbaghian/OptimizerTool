using SferaHandlers;
using System.Xml;

public class XmlParser : IXmlParser
{
    public static (ISferaMessage, string, string, bool) DeserializeXmlFile(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
        {
            throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
        }

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("The specified file does not exist.", filePath);
        }

        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(filePath);
        }
        catch (XmlException ex)
        {
            throw new InvalidOperationException("Failed to load XML document.", ex);
        }

        XmlElement? documentElement = xmlDoc.DocumentElement;
        if (documentElement == null)
            throw new InvalidOperationException("The XML document is empty.");

        string rootElement = documentElement.Name;

        // Try to find the MessageHeader element
        XmlNode? messageHeader = documentElement.SelectSingleNode("MessageHeader");
        string version = string.Empty;

        if (messageHeader != null)
        {
            // Try SFERA_version first
            var sferaVersion = messageHeader.Attributes?["SFERA_version"]?.Value;
            if (!string.IsNullOrEmpty(sferaVersion))
            {
                version = sferaVersion;
            }
            else
            {
                // Try SFERA_version_major and SFERA_version_minor
                var major = messageHeader.Attributes?["SFERA_version_major"]?.Value;
                var minor = messageHeader.Attributes?["SFERA_version_minor"]?.Value;
                if (!string.IsNullOrEmpty(major) && !string.IsNullOrEmpty(minor))
                {
                    version = $"{major}.{minor}";
                }
            }
        }

        // Fallback: try root element attributes
        if (string.IsNullOrEmpty(version))
        {
            version = documentElement.GetAttribute("version");
            if (string.IsNullOrEmpty(version))
            {
                version = documentElement.GetAttribute("SFERA_version");
            }
        }

        // Check if the XML contains any element or subelement named "SegmentProfile"
        bool containsSegmentProfile = xmlDoc.GetElementsByTagName("SegmentProfile").Count > 0;

        var handler = SferaMessageHandlerFactory.GetHandler(version);
        var message = handler.Deserialize(filePath);

        return (message, rootElement, version, containsSegmentProfile);
    }
}