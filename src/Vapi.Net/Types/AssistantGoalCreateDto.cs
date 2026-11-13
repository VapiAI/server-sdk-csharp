using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantGoalCreateDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Success criteria. Trimmed before commit; blank or non-PostgreSQL-compatible text is rejected.
    /// </summary>
    [JsonPropertyName("succeedsWhen")]
    public required string SucceedsWhen { get; set; }

    /// <summary>
    /// Optional trimmed exclusions. Omit or send null for no exclusions.
    /// </summary>
    [JsonPropertyName("leaveOut")]
    public string? LeaveOut { get; set; }

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
