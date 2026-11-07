using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallArtifactControllerStereoRecordingDownloadRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
