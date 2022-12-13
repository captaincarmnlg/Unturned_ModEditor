using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Enums.Item.Barricades;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Tank : Barricade
    {
        new public ItemType Type { get; } = ItemType.Tank;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Tank;
        public TankType Source { get; set; }
        public int Resource { get; set; }
    }
}
