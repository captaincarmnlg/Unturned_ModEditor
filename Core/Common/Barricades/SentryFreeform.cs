using Core.Context.Enums.Item;

namespace Core.Common.Barricades
{
    public class SentryFreeform : Sentry
    {
        new public ItemType Type { get; } = ItemType.Sentry_Freeform;
    }
}
