using System.Reflection;

namespace Shared.Models
{
    public class Segment
    {
        public float Start { get; set; }
        public float End { get; set; }
        public float Length => End - Start;
        public override string ToString()
        {
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propertyValues = properties.Select(p => $"{p.Name}: {p.GetValue(this)}");
            return string.Join(", ", propertyValues);
        }
    }
}