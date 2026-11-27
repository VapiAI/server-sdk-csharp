using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardAffectedCallDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("callId")]
    public required string CallId { get; set; }

    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// Call completion time (endedAt), never startedAt.
    /// </summary>
    [JsonPropertyName("callTime")]
    public required DateTime CallTime { get; set; }

    [JsonPropertyName("callAvailability")]
    public required CallHealthDashboardAffectedCallDtoCallAvailability CallAvailability { get; set; }

    /// <summary>
    /// The assistant version the call ran on; absent when it ran on none.
    /// </summary>
    [JsonPropertyName("assistantVersionId")]
    public string? AssistantVersionId { get; set; }

    /// <summary>
    /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
