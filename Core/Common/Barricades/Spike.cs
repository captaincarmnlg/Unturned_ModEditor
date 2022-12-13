using Core.Context.Common;
using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Spike : Barricade
    {
        new public ItemType Type { get; } = ItemType.Trap;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Spike;
        public SingleValueBool Damage_Tires { get; set; }
        public int Range2 { get; set; }
        public int Explosion2 { get; set; }
    }
}
