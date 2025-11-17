using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PhoneNumberCallEndingHookFilter
{
    /// <summary>
    /// This is the type of filter - currently only "oneOf" is supported
    /// </summary>
    [JsonPropertyName("type")]
    public required PhoneNumberCallEndingHookFilterType Type { get; set; }

    /// <summary>
    /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
    /// </summary>
    [JsonPropertyName("key")]
    public required PhoneNumberCallEndingHookFilterKey Key { get; set; }

    /// <summary>
    /// This is the array of assistant-request related ended reasons to match against
    /// </summary>
    [JsonPropertyName("oneOf")]
    public IEnumerable<PhoneNumberCallEndingHookFilterOneOfItem> OneOf { get; set; } =
        new List<PhoneNumberCallEndingHookFilterOneOfItem>();

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
