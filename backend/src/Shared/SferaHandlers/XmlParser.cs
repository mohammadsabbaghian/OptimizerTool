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
        {
            throw new InvalidOperationException("The XML document is empty.");
        }

        string rootElement = documentElement.Name;
        string version = documentElement.GetAttribute("version");
        if (string.IsNullOrEmpty(version))
        {
            throw new InvalidOperationException("The XML document does not specify a version.");
        }

        // Check if the XML contains any element or subelement named "SegmentProfile"
        bool containsSegmentProfile = xmlDoc.GetElementsByTagName("SegmentProfile").Count > 0;

        var handler = SferaMessageHandlerFactory.GetHandler(version);
        var message = handler.Deserialize(filePath);

        return (message, rootElement, version, containsSegmentProfile);
    }
}