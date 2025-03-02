namespace SferaHandlers
{
    public interface IXmlParser
    {
        static abstract (ISferaMessage, string) DeserializeXmlFile(string filePath);
    }
}