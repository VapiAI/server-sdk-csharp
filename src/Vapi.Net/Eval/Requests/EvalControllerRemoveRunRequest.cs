using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EvalControllerRemoveRunRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
