using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PersonalityControllerRemoveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
