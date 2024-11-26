using System.Xml;
using System.Xml.Serialization;


namespace SferaHandlers
{
    public class XmlParser
    {
        public static ISferaMessage DeserializeXmlFile(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            string rootElement = xmlDoc.DocumentElement.Name;

            if (rootElement == "SFERA_B2G_EventMessage")
            {
                return DeserializeXml<SFERA_B2G_EventMessage>(filePath);
            }
            else if (rootElement == "SFERA_B2G_RequestMessage")
            {
                return DeserializeXml<SFERA_B2G_RequestMessage>(filePath);
            }
            else if (rootElement == "SFERA_B2G_ReplyMessage")
            {
                return DeserializeXml<SFERA_B2G_ReplyMessage>(filePath);
            }
            else if (rootElement == "SFERA_G2B_EventMessage")
            {
                return DeserializeXml<SFERA_G2B_EventMessage>(filePath);
            }
            else if (rootElement == "SFERA_G2B_ReplyMessage")
            {
                return DeserializeXml<SFERA_G2B_ReplyMessage>(filePath);
            }
            else if (rootElement == "SFERA_G2B_RequestMessage")
            {
                return DeserializeXml<SFERA_G2B_RequestMessage>(filePath);
            }
            else
            {
                throw new InvalidOperationException("Unknown XML type");
            }
        }

         static T DeserializeXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }
    }
}
