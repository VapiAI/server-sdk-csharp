using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallArtifactControllerCallLogsDownloadRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
