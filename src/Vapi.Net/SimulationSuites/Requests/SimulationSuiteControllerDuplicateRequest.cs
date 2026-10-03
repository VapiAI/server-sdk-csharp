using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationSuiteControllerDuplicateRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
