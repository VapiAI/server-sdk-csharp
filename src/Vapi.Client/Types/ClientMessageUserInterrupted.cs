using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ClientMessageUserInterrupted
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}