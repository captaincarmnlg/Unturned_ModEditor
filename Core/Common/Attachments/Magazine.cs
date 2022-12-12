using Core.Context.Common;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Attachments;

namespace Core.Common.Attachments
{
    public class Magazine : Attachment
    {
        new public ItemType Type { get; } = ItemType.Magazine;
        public int Pellets { get; set; } // Number of bullet rays shot.
        public int Tracer { get; set; } // Tracer effect ID.
        public int Impact { get; set; } // Impact effect ID.
        public float Speed { get; set; } // Multiplier on reload speed.
        public int Stuck { get; set; } // Amount of quality to lose when hit. Fired projectiles can be picked back up until quality reaches 0.
        public float Projectile_Damage_Multiplier { get; set; } // Multiplier on the damage dealt by projectile weapons.
        public float Projectile_Blast_Radius_Multiplier { get; set; } // Multiplier on the blast radius of projectiles fired from projectile weapons.
        public float Projectile_Launch_Force_Multiplier { get; set; } // Multiplier on the launch force applied to projectiles fired from projectile weapons.
        public SingleValueBool Should_Fill_After_Detach { get; set; } // Specified if ammunition is fully refilled when reloaded, effectively allowing for infinite ammunition only limited by reload time.
        public SingleValueBool Delete_Empty { get; set; } // Specified if the magazine should be deleted when depleted.
    }
}
