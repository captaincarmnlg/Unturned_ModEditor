using Core.Context.Enums;

namespace Core.Common.Barricades
{
    public class Wire : Spike
    {
        new public BuildType Build { get; } = BuildType.Wire;
    }
}
