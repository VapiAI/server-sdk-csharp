using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ProviderResource
{
    /// <summary>
    /// This is the unique identifier for the provider resource.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this provider resource belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the provider resource was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the provider resource was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the provider that manages this resource.
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "11labs";

    /// <summary>
    /// This is the name/type of the resource.
    /// </summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; } = "pronunciation-dictionary";

    /// <summary>
    /// This is the provider-specific identifier for the resource.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public required string ResourceId { get; set; }

    /// <summary>
    /// This is the full resource data from the provider's API.
    /// </summary>
    [JsonPropertyName("resource")]
    public required ElevenLabsPronunciationDictionary Resource { get; set; }

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
