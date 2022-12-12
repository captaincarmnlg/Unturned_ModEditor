﻿using Core.Context.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context.Models.Item.Damage
{
    public class ZombieDamage
    {
        public int Zombie_Damage { get; set; }
        public float Zombie_Leg_Multiplier { get; set; }
        public float Zombie_Arm_Multiplier { get; set; }
        public float Zombie_Spine_Multiplier { get; set; }
        public float Zombie_Skull_Multiplier { get; set; }
    }
}
