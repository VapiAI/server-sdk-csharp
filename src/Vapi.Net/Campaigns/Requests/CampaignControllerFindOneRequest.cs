using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CampaignControllerFindOneRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
