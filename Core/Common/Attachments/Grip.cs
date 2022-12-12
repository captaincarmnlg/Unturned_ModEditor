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
    public class Grip : Attachment
    {
        new public ItemType Type { get; } = ItemType.Grip;
        public SingleValueBool Bipod { get; set; } // Specified if effects only take place when prone.
    }
}
