using Core.Context.Enums.Item.Damage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context.Models.Item.Damage
{
    public class PlayerDamage
    {
        public int Player_Damage { get; set; }
        public float Player_Leg_Multiplier { get; set; }
        public float Player_Arm_Multiplier { get; set; }
        public float Player_Spine_Multiplier { get; set; }
        public float Player_Skull_Multiplier { get; set; }
        public DamageBleedingType Player_Damage_Bleeding { get; set; }
        public DamageBonesType Player_Damage_Bones { get; set; }
        public int Player_Damage_Food { get; set; }
        public int Player_Damage_Water { get; set; }
        public int Player_Damage_Virus { get; set; }
        public int Player_Damage_Hallucination { get; set; }
    }
}
