using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateFileDto
{
    public required FileParameter File { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
