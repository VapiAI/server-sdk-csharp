using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficAllocationControllerFindOneRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
