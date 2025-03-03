using Vapi.Net.Core;

namespace Vapi.Net;

public record SbcConfiguration
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
