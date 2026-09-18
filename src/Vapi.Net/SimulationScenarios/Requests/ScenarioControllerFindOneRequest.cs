using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ScenarioControllerFindOneRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
