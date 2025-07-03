using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CustomEndpointingModelSmartEndpointingPlan
{
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
