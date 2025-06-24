using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Session
{
    /// <summary>
    /// This is the unique identifier for the session.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization that owns this session.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 timestamp indicating when the session was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 timestamp indicating when the session was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is a user-defined name for the session. Maximum length is 40 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the current status of the session. Can be either 'active' or 'completed'.
    /// </summary>
    [JsonPropertyName("status")]
    public SessionStatus? Status { get; set; }

    /// <summary>
    /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.
    /// </summary>
    [JsonPropertyName("expirationSeconds")]
    public double? ExpirationSeconds { get; set; }

    /// <summary>
    /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.
    /// If assistantId is provided, this will be ignored.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is an array of chat messages in the session.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<SystemMessage, UserMessage, AssistantMessage, ToolMessage, DeveloperMessage>
    >? Messages { get; set; }

    /// <summary>
    /// This is the customer information associated with this session.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the ID of the phone number associated with this session.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the phone number configuration for this session.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public ImportTwilioPhoneNumberDto? PhoneNumber { get; set; }

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
