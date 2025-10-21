using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record HandoffDestinationDynamic
{
    /// <summary>
    /// This is where Vapi will send the handoff-destination-request webhook in a dynamic handoff.
    ///
    /// The order of precedence is:
    ///
    /// 1. tool.server.url
    /// 2. assistant.server.url
    /// 3. phoneNumber.server.url
    /// 4. org.server.url
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
