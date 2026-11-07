using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Identifies an assistant that became active during a call.
/// </summary>
[Serializable]
public record AssistantActivation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the version label (e.g. `v3`) of the assistant active when
    /// the activation row was recorded. Absent for inline assistants,
    /// orgs not on assistant versioning, and parent assistants that have
    /// not yet been published under it.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// This is the version label (e.g. `v3`) of the squad that was governing the
    /// call when this activation was recorded. Absent for activations that no
    /// squad version governs: standalone-assistant calls, flag-off orgs, squads
    /// with no published version, and hops to an assistant outside the squad.
    /// </summary>
    [JsonPropertyName("squadVersion")]
    public string? SquadVersion { get; set; }

    /// <summary>
    /// This is the name of the assistant that was active during the call.
    /// </summary>
    [JsonPropertyName("assistantName")]
    public required string AssistantName { get; set; }

    /// <summary>
    /// This is the ID of the assistant that was active during the call.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

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
