using Core.Context.Enums.Item;
using Core.Context.Models.Item.Attachments;

namespace Core.Common.Attachments
{
    public class Sight : Attachment
    {
        new public ItemType Type { get; } = ItemType.Sight;
        public int Zoom { get; set; } // Multiplicative amount of zoom.
    }
}
