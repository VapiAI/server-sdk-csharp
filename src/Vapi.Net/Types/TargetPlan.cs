using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TargetPlan
{
    /// <summary>
    /// This is the phone number that is being tested.
    /// During the actual test, it'll be called and the assistant attached to it will pick up and be tested.
    /// To test an assistant directly, send assistantId instead.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This can be any phone number (even not on Vapi).
    /// During the actual test, it'll be called.
    /// To test a Vapi number, send phoneNumberId. To test an assistant directly, send assistantId instead.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public TestSuitePhoneNumber? PhoneNumber { get; set; }

    /// <summary>
    /// This is the assistant being tested.
    /// During the actual test, it'll invoked directly.
    /// To test the assistant over phone number, send phoneNumberId instead.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant overrides applied to assistantId before it is tested.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

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
