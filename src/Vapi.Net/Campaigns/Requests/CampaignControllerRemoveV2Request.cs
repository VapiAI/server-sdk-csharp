using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CampaignControllerRemoveV2Request
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
