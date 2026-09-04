using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// An assistant member of a squad. Reference a saved assistant or provide a transient assistant, then configure member-specific overrides and destinations for transfers.
/// </summary>
[Serializable]
public record SquadMemberDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the assistant version (e.g. `v3`) to pin for this squad member. When set, the call uses
    /// the snapshot from `assistant_version` (by `(assistantId, version)`) instead of the latest. Valid
    /// only with `assistantId`; rejected with inline `assistant`. Omit to follow the latest version.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// Assistants this squad member can route the conversation to through a transfer or handoff.
    /// </summary>
    [JsonPropertyName("assistantDestinations")]
    public IEnumerable<
        OneOf<TransferDestinationAssistant, HandoffDestinationAssistant>
    >? AssistantDestinations { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use a transient assistant, use `assistant` instead.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This can be used to override the assistant's settings and provide values for it's template variables.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

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
