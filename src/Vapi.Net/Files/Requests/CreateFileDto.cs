using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateFileDto
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
