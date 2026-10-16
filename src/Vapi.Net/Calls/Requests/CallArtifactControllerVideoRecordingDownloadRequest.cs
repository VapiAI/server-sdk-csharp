using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallArtifactControllerVideoRecordingDownloadRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
