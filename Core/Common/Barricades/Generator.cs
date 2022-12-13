using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Generator : Barricade
    {
        new public ItemType Type { get; } = ItemType.Generator;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Generator;
        new public int Capacity { get; set; }
        public int Wirerange { get; set; }
        public int Burn { get; set; }
    }
}
