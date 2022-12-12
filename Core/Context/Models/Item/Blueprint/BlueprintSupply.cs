using Core.Context.Common;

namespace Core.Context.Models.Item.Blueprint
{
    public class BlueprintSupply
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public SingleValueBool Critical { get; set; }
    }
}
