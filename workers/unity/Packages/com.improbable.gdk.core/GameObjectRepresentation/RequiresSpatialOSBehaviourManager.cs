using Unity.Entities;

namespace Improbable.Gdk.Core
{
    /// <summary>
    ///     Tag component for marking entities that require a RequiresSpatialOSBehaviourManager.
    /// </summary>
    [RemoveAtEndOfTick]
    public struct RequiresSpatialOSBehaviourManager : IComponentData
    {
    }
}
