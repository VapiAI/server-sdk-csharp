using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationSuiteControllerRemoveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
