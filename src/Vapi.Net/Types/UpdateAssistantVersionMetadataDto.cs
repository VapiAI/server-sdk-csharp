using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateAssistantVersionMetadataDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional human-readable label for this version. Pass `null` to clear.
    /// </summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }

    /// <summary>
    /// Optional description for this version. Pass `null` to clear.
    /// </summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

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
