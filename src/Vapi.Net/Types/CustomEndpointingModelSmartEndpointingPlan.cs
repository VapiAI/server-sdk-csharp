using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CustomEndpointingModelSmartEndpointingPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the provider for the smart endpointing plan. Use `custom-endpointing-model` for custom endpointing providers that are not natively supported.
    /// </summary>
    [JsonPropertyName("provider")]
    public required CustomEndpointingModelSmartEndpointingPlanProvider Provider { get; set; }

    /// <summary>
    /// This is where the endpointing request will be sent. If not provided, will be sent to `assistant.server`. If that does not exist either, will be sent to `org.server`.
    ///
    /// Request Example:
    ///
    /// POST https://{server.url}
    /// Content-Type: application/json
    ///
    /// {
    ///   "message": {
    ///     "type": "call.endpointing.request",
    ///     "messages": [
    ///       {
    ///         "role": "user",
    ///         "message": "Hello, how are you?",
    ///         "time": 1234567890,
    ///         "secondsFromStart": 0
    ///       }
    ///     ],
    ///     ...other metadata about the call...
    ///   }
    /// }
    ///
    /// Response Expected:
    /// {
    ///   "timeoutSeconds": 0.5
    /// }
    ///
    /// The timeout is the number of seconds to wait before considering the user's speech as finished. The endpointing timeout is automatically reset each time a new transcript is received (and another `call.endpointing.request` is sent).
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

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
