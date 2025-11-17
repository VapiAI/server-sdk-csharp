using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GetPhoneNumbersRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
