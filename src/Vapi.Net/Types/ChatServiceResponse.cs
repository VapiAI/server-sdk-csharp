using Vapi.Net.Core;

namespace Vapi.Net;

public record ChatServiceResponse
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
