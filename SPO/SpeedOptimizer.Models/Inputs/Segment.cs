using System.Reflection;

namespace SpeedOptimizer.Models.Inputs
{
    public class Segment
    {
        public float Start { get; set; }
        public float End { get; set; }
        public float Length => End - Start;
        public override string ToString()
        {
            var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propertyValues = properties.Select(p => $"{p.Name}: {p.GetValue(this)}");
            return string.Join(", ", propertyValues);
        }
    }
}