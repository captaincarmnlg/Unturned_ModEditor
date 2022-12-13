using Core.Context.Enums;

namespace Core.Common.Barricades
{
    public class StorageWall : Storage
    {
        new public BuildType Build { get; } = BuildType.Storage_Wall;
    }
}
