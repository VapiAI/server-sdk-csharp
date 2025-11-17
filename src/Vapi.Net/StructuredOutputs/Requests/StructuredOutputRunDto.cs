using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record StructuredOutputRunDto
{
    /// <summary>
    /// This is the preview flag for the re-run. If true, the re-run will be executed and the response will be returned immediately and the call artifact will NOT be updated.
    /// If false (default), the re-run will be executed and the response will be updated in the call artifact.
    /// </summary>
    [JsonPropertyName("previewEnabled")]
    public bool? PreviewEnabled { get; set; }

    /// <summary>
    /// This is the ID of the structured output that will be run. This must be provided unless a transient structured output is provided.
    /// When the re-run is executed, only the value of this structured output will be replaced with the new value, or added if not present.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public string? StructuredOutputId { get; set; }

    /// <summary>
    /// This is the transient structured output that will be run. This must be provided if a structured output ID is not provided.
    /// When the re-run is executed, the structured output value will be added to the existing artifact.
    /// </summary>
    [JsonPropertyName("structuredOutput")]
    public CreateStructuredOutputDto? StructuredOutput { get; set; }

    /// <summary>
    /// This is the array of callIds that will be updated with the new structured output value. If preview is true, this array must be provided and contain exactly 1 callId.
    /// If preview is false, up to 100 callIds may be provided.
    /// </summary>
    [JsonPropertyName("callIds")]
    public IEnumerable<string> CallIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
