using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TransferFallbackPlan
{
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
