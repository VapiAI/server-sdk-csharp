using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record DeleteChatsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
