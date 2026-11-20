using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueVersionDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The version the calls ran on; null groups the calls that ran on no version.
    /// </summary>
    [JsonPropertyName("assistantVersionId")]
    public string? AssistantVersionId { get; set; }

    /// <summary>
    /// The version's label, such as v3; absent for calls on no version or whose label was unavailable at registration.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// Distinct visible calls on this version matching the issue in the window.
    /// </summary>
    [JsonPropertyName("affectedCallCount")]
    public required int AffectedCallCount { get; set; }

    /// <summary>
    /// Accepted current-goal outcomes on this version for the issue's assistant in the window.
    /// </summary>
    [JsonPropertyName("analyzedCallCount")]
    public required int AnalyzedCallCount { get; set; }

    /// <summary>
    /// affectedCallCount / analyzedCallCount; omitted for a zero denominator.
    /// </summary>
    [JsonPropertyName("affectedCallRate")]
    public double? AffectedCallRate { get; set; }

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
