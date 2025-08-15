using TrainCharacteristicsManager;

public class TrainCharacteristicsBuilderProvider
{
    private Task<TrainCharacteristicsBuilder>? _builderTask;
    public Task<TrainCharacteristicsBuilder> GetBuilderAsync()
    {
        return _builderTask ??= TrainCharacteristicsBuilder.CreateAsync();
    }
}

