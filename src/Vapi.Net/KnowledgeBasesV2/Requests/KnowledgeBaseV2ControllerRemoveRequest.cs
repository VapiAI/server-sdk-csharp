using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record KnowledgeBaseV2ControllerRemoveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
