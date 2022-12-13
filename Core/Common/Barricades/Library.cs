using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Library : Barricade
    {
        new public ItemType Type { get; } = ItemType.Library;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Library;
        new public int Capacity { get; set; }
        public int Tax { get; set; }
    }
}
