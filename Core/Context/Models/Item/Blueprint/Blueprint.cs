using Core.Context.Common;
using Core.Context.Enums.Item.Blueprint;

namespace Core.Context.Models.Item.Blueprint
{
    public class Blueprint
    {
        public BlueprintType Type { get; set; }
        public int Level { get; set; }
        public SkillType Skill { get; set; }

        public int Tool { get; set; }
        public SingleValueBool Tool_Critical { get; set; }

        public int Product { get; set; }
        public int Products { get; set; }

        public int Build { get; set; }
        public string Map { get; set; } = default!;

        public List<BlueprintSupply> Supplies { get; set; } = default!;
        public List<BlueprintOutput> Outputs { get; set; } = default!;
        public List<BlueprintConditions> Conditions { get; set; } = default!;

    }
}
