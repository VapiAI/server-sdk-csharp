using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record KnowledgeBaseV2ControllerFindOneRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
