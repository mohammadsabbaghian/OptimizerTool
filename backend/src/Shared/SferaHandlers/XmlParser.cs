using System.Xml;
using System.Xml.Serialization;


namespace SferaHandlers
{
    public class XmlParser : IXmlParser
    {
        public static (ISferaMessage, string) DeserializeXmlFile(string filePath)
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

            return rootElement switch
            {
                "SFERA_B2G_EventMessage" => (DeserializeXml<SFERA_B2G_EventMessage>(filePath), rootElement),
                "SFERA_B2G_RequestMessage" => (DeserializeXml<SFERA_B2G_RequestMessage>(filePath), rootElement),
                "SFERA_B2G_ReplyMessage" => (DeserializeXml<SFERA_B2G_ReplyMessage>(filePath), rootElement),
                "SFERA_G2B_EventMessage" => (DeserializeXml<SFERA_G2B_EventMessage>(filePath), rootElement),
                "SFERA_G2B_ReplyMessage" => (DeserializeXml<SFERA_G2B_ReplyMessage>(filePath), rootElement),
                "SFERA_G2B_RequestMessage" => (DeserializeXml<SFERA_G2B_RequestMessage>(filePath), rootElement),
                _ => throw new InvalidOperationException("Unknown XML type")
            };
        }

        static T DeserializeXml<T>(string filePath) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return serializer.Deserialize(fileStream) as T ??
                    throw new InvalidOperationException($"Failed to deserialize XML to {typeof(T).Name}.");
            }
        }
    }
}
