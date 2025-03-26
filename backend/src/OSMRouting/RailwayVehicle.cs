using Itinero.Attributes;
using Itinero.Profiles;

public class Railway : Vehicle
{
    public Railway()
    {
        this.Register(new Profile("shortest", ProfileMetric.DistanceInMeters, new[] { "railway" }, null, this));
        this.Register(new Profile("fastest", ProfileMetric.TimeInSeconds, new[] { "railway" }, null, this));
    }

    public override string Name => "Railway";

    public override string[] VehicleTypes => new[] { "railway" };

    public override FactorAndSpeed FactorAndSpeed(IAttributeCollection attributes, Whitelist whitelist)
    {
        if (attributes != null && attributes.TryGetValue("railway", out _))
        {
            return new FactorAndSpeed()
            {
                SpeedFactor = 1 / (80f / 3.6f), // Example speed factor
                Value = 1 / (80f / 3.6f), // Example speed value
                Direction = 0
            };
        }
        return new FactorAndSpeed()
        {
            SpeedFactor = 0,
            Value = 0,
            Direction = 0
        };
    }
}
