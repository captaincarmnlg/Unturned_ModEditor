using Core.Context.Common;
using Core.Context.Enums;
using Core.Context.Enums.Item;
using Core.Context.Enums.Item.Barricades;

namespace Core.Context.Models.Item.Barricades
{
    public class Barricade : Item
    {
        new public UsableType Usable { get; } = UsableType.Barricade;
        public BuildType Build { get; set; }
        public int Health { get; set; } // Amount of health.
        public int Range { get; set; } // Distance away the barricade can be placed from the player.
        public int Radius { get; set; }
        public int Offset { get; set; } // Inherent distance above the point to place.
        public SingleValueBool Locked { get; set; } // Usability/interactivity access restricted to owner.
        public int Explosion { get; set; } // Destruction effect ID.
        public float Salvage_Duration_Multiplier { get; set; }
        public SingleValueBool Unpickupable { get; set; }
        public SingleValueBool Unrepairable { get; set; }
        public SingleValueBool Unsalvageable { get; set; }
        public SingleValueBool Unsaveable { get; set; }
        public SingleValueBool Vulnerable { get; set; }
        public SingleValueBool Proof_Explosion { get; set; }
        public ArmorTierType Armor_Tier { get; set; }
        public SingleValueBool Use_Water_Height_Transparent_Sort { get; set; }
        public Boolean Should_Close_When_Outside_Range { get; set; }
        public SingleValueBool Allow_Collision_While_Animating { get; set; }
        public SingleValueBool Allow_Placement_On_Vehicle { get; set; }

    }
}
