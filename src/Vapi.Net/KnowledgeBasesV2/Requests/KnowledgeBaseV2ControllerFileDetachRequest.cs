using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record KnowledgeBaseV2ControllerFileDetachRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
