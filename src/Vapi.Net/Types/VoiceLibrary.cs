using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VoiceLibrary
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [JsonPropertyName("provider")]
    public object? Provider { get; set; }

    /// <summary>
    /// The ID of the voice provided by the provider.
    /// </summary>
    [JsonPropertyName("providerId")]
    public string? ProviderId { get; set; }

    /// <summary>
    /// The unique slug of the voice.
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    /// <summary>
    /// The name of the voice.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The language of the voice.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// The language code of the voice.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// The model of the voice.
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// The supported models of the voice.
    /// </summary>
    [JsonPropertyName("supportedModels")]
    public string? SupportedModels { get; set; }

    /// <summary>
    /// The gender of the voice.
    /// </summary>
    [JsonPropertyName("gender")]
    public VoiceLibraryGender? Gender { get; set; }

    /// <summary>
    /// The accent of the voice.
    /// </summary>
    [JsonPropertyName("accent")]
    public string? Accent { get; set; }

    /// <summary>
    /// The preview URL of the voice.
    /// </summary>
    [JsonPropertyName("previewUrl")]
    public string? PreviewUrl { get; set; }

    /// <summary>
    /// The description of the voice.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The credential ID of the voice.
    /// </summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>
    /// The unique identifier for the voice library.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The unique identifier for the organization that this voice library belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// The Public voice is shared accross all the organizations.
    /// </summary>
    [JsonPropertyName("isPublic")]
    public required bool IsPublic { get; set; }

    /// <summary>
    /// The deletion status of the voice.
    /// </summary>
    [JsonPropertyName("isDeleted")]
    public required bool IsDeleted { get; set; }

    /// <summary>
    /// The ISO 8601 date-time string of when the voice library was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The ISO 8601 date-time string of when the voice library was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
