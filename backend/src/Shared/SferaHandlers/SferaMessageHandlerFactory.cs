public static class SferaMessageHandlerFactory
{
    private static readonly List<ISferaMessageHandler> Handlers = new()
    {
        new SferaMessageHandler_v2_01(),
        new SferaMessageHandler_v3_00()
    };

    public static ISferaMessageHandler GetHandler(string version)
    {
        var handler = Handlers.FirstOrDefault(h => h is SferaMessageHandler_v2_01 && version == "2.01" ||
                                                   h is SferaMessageHandler_v3_00 && version == "3.00");
        if (handler == null)
        {
            throw new InvalidOperationException($"Unsupported version: {version}");
        }
        return handler;
    }
}