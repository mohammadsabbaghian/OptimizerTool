namespace SferaHandlers
{
    public interface IXmlParser
    {
        static abstract (ISferaMessage, string, string, bool) DeserializeXmlFile(string filePath);
    }
}