using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Charge : Barricade
    {
        new public ItemType Type { get; } = ItemType.Charge;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Charge;
        public int Range2 { get; set; }
        public int Explosion2 { get; set; }
    }
}
