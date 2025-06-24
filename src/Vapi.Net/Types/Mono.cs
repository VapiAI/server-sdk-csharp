using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Mono
{
    /// <summary>
    /// This is the combined recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("combinedUrl")]
    public string? CombinedUrl { get; set; }

    /// <summary>
    /// This is the mono recording url for the assistant. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("assistantUrl")]
    public string? AssistantUrl { get; set; }

    /// <summary>
    /// This is the mono recording url for the customer. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("customerUrl")]
    public string? CustomerUrl { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
