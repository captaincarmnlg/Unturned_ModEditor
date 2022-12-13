using Core.Context.Common;
using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Enums.Item.Barricades;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class Sentry : Barricade
    {
        new public ItemType Type { get; } = ItemType.Sentry;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Sentry;
        public int Storage_X { get; set; }
        public int Storage_Y { get; set; }
        public SingleValueBool Display { get; set; }
        public SentryModeType Mode { get; set; }
        public SingleValueBool Infinite_Ammo { get; set; }
        public SingleValueBool Infinite_Quality { get; set; }
    }
}
