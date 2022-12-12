using Core.Context.Common;
using Core.Context.Enums.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context.Models.Item
{
    public class Item
    {
        public char[] ID { get; set; } = new char[32]; // The GUID is automatically generated for the item when the game is launched. If it is not automatically generated, then it is assumable that the content was not set up properly.
        public ItemType Type { get; set; } // Each category of item has its own type. The type to use can be found for each specific item category below, and is used for the item's context type as viewed in the context menu.
        public RarityType Rarity { get; set; } // This defines which class to use for the item when equipped. If unspecified it will default to None, meaning that the item cannot be equipped. Which value to use for equippable items can be found below for each item category.
        public SlotType Slot { get; set; } // Item inventory slot type.
        public ItemSize Size { get; set; } = default!; // Item inventory slot size.
        public ItemCapacity Capacity { get; set; } = default!; // Generic item capacity
        public ItemQuality Quality { get; set; } = default!;  // Generic item quality (durability)
        public ItemDamage Damage { get; set; } = default!; // Item damage modifiers

        public bool Can_Use_Underwater { get; set; } // Item usable under water.
        public bool Should_Drop_On_Death { get; set; } // Drop item on death.
        public bool Should_Delete_At_Zero_Quality { get; set; } // Item removed if quality zero.
        public bool Allow_Manual_Drop { get; set; } // Allowed to drop item
        public SingleValueBool Backward { get; set; } = default!; // Specified if this item should be visually held in the opposite hand.

        public List<Blueprint.Blueprint> Blueprints { get; set; } = default!; // The number of unique supplies required for the blueprint.
        public List<Action.Action> Actions { get; set; } = default!; // The number of actions available.
    }
}
