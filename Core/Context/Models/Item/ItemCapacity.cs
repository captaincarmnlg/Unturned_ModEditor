namespace Core.Context.Models.Item
{
    public class ItemCapacity
    {
        public int Amount { get; set; } // Maximum capacity of a container.
        public int Count_Min { get; set; } // The minimum amount to generate in the container.
        public int Count_Max { get; set; } // The maximum amount to generate in the container.

    }
}
