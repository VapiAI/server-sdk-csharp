using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationSuiteControllerFindOneRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
