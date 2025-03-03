using Vapi.Net.Core;

namespace Vapi.Net;

public record FailedEdgeCondition
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
