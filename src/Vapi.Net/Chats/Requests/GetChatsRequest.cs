using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GetChatsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
