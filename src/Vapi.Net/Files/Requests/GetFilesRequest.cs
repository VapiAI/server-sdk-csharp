using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GetFilesRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
