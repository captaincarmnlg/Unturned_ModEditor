using Core.Context.Common;
using Core.Context.Models.Item.Damage;

namespace Core.Context.Models.Item
{
    public class ItemDamage
    {
        public PlayerDamage PlayerDamage { get; set; } = default!;
        public ZombieDamage ZombieDamage { get; set; } = default!;
        public AnimalDamage AnimalDamage { get; set; } = default!;
        public int Barricade_Damage { get; set; }
        public int Structure_Damage { get; set; }
        public int Vehicle_Damage { get; set; }
        public int Resource_Damage { get; set; }
        public int Object_Damage { get; set; }
        public int Range { get; set; }
        public int Explosion { get; set; }

        public bool Instakill_Headshots { get; set; }
        public SingleValueBool Invulnerable { get; set; }
        public SingleValueBool Explosive { get; set; }
        public SingleValueBool Spawn_Explosion_On_Dedicated_Server { get; set; }
    }
}
