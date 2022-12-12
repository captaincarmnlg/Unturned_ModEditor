using Core.Context.Common;
using Core.Context.Enums.Blueprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context.Models.Item.Blueprint
{
    public class BlueprintConditions
    {
        public ConditionType Type { get; set; }
        public ConditionValue Value { get; set; }
    }
}
