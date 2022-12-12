using Core.Context.Common;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Attachments;

namespace Core.Common.Attachments
{
    public class Barrel : Attachment
    {
        new public ItemType Type { get; } = ItemType.Barrel;
        public SingleValueBool Braked { get; set; } // Specified if a muzzle flash is hidden.
        public SingleValueBool Silenced { get; set; } // Specified if alerts are not generated.
        public int Volume { get; set; } // Amount to multiply gunfire sound volume.
    }
}
