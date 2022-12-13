using Core.Context.Common;
using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Storage : Barricade
    {
        new public ItemType Type { get; } = ItemType.Storage;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Storage;
        public int Storage_X { get; set; }
        public int Storage_Y { get; set; }
        public SingleValueBool Display { get; set; }
    }
}
