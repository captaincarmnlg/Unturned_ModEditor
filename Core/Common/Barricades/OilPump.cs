using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Barricades;

namespace Core.Common.Barricades
{
    public class OilPump : Barricade
    {
        new public ItemType Type { get; } = ItemType.Oil_Pump;
        new public UsableType Usable { get; } = UsableType.Barricade;
        new public BuildType Build { get; } = BuildType.Oil;
        public int Fuel_Capacity { get; set; }
    }
}
