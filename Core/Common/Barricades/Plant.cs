using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Plant : Barricade
    {
        new public ItemType Type { get; } = ItemType.Farm;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Farm;
        public int Growth { get; set; }
        public int Grow { get; set; }
    }
}
