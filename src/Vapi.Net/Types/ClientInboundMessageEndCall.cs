using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientInboundMessageEndCall
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
