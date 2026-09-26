using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationControllerFindOneRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
