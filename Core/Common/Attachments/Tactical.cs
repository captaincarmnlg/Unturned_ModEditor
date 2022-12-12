using Core.Context.Common;
using Core.Context.Enums.Item;
using Core.Context.Models.Item.Attachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Attachments
{
    public class Tactical : Attachment
    {
        new public ItemType Type { get; } = ItemType.Tactical;
        public int Firerate { get; set; } // Amount to decrease minimum fire rate delay.
        public SingleValueBool Laser { get; set; } // Specified if a laser can be toggled.
        public SingleValueBool Light { get; set; } // Specified if a light can be toggled.
        public SingleValueBool Rangefinder { get; set; } // Specified if a rangefinder can be toggled.
        public SingleValueBool Melee { get; set; } // Specified if a melee attack can be performed.
    }
}
