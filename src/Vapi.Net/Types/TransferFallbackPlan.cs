using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TransferFallbackPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the message the assistant will deliver to the customer if the transfer fails.
    /// </summary>
    [JsonPropertyName("message")]
    public required OneOf<string, CustomMessage> Message { get; set; }

    /// <summary>
    /// This controls what happens after delivering the failure message to the customer.
    /// - true: End the call after delivering the failure message (default)
    /// - false: Keep the assistant on the call to continue handling the customer's request
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("endCallEnabled")]
    public bool? EndCallEnabled { get; set; }

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
