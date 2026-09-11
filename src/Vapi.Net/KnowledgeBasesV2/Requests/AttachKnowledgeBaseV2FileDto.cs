using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AttachKnowledgeBaseV2FileDto
{
    [JsonPropertyName("fileId")]
    public required string FileId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
