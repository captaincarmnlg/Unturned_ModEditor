using Core.Context.Common;

namespace Core.Context.Models.Item
{
    public class ItemQuality
    {
        public int Quality_Min { get; set; } // The minimum quality to generate. Set to 10 by default.
        public int Quality_Max { get; set; } // The maximum quality to generate. Set to 90 by default.
        public SingleValueBool Override_Show_Quality { get; set; } = default!; // No info yet....
        public double Durability { get; set; } // Either a decimal probability chance of quality loss upon action, or guaranteed loss and durability value is instead representative of the amount lost.
        public double Wear { get; set; } // Increment to degrade quality by. Only applicable to items where durability represents a decimal probability chance of quality loss.
    }
}
