using Vapi.Net.Core;

namespace Vapi.Net;

public record AssistantHookActionBase
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
