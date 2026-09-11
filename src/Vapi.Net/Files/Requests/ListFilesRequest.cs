using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ListFilesRequest
{
    [JsonIgnore]
    public required string Purpose { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
