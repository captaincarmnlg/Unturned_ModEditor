using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Beacon : Barricade
    {
        new public ItemType Type { get; } = ItemType.Barricade;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Barricade;
        public int Wave { get; set; }
        public List<BeaconReward> Rewards { get; set; } = default!;
    }
}
