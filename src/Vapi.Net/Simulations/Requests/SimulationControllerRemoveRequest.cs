using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationControllerRemoveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
