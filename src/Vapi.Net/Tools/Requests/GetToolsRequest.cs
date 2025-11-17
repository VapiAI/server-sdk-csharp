using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GetToolsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
