namespace Core.Context.Models.Item.Action
{
    public class Action
    {
        public ActionType Type { get; set; } // ID of the item with the blueprint this action should perform.
        public ActionKey Key { get; set; }
        public int Source { get; set; }
        public List<ActionBlueprint> Blueprints { get; set; } = default!; // The amount of the unique blueprint actions.
    }
}
