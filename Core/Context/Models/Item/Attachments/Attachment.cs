using Core.Context.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context.Models.Item.Attachments
{
    public class Attachment : Item
    {
        public double Recoil_X { get; set; }
        public double Recoil_Y { get; set; }
        public double Spread { get; set; }
        public double Shake { get; set; }
        new public double Damage { get; set; }
        public SingleValueBool Paintable { get; set; }
        public List<AttachmentCaliber> Calibers { get; set; } = default!;
    }
}
