using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateFileDto
{
    public required FileParameter File { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
