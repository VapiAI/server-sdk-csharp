using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientInboundMessageSay
{
    /// <summary>
    /// This is the content to say.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// This is the flag to end call after content is spoken.
    /// </summary>
    [JsonPropertyName("endCallAfterSpoken")]
    public bool? EndCallAfterSpoken { get; set; }

    /// <summary>
    /// This is the flag for whether the message is interruptible.
    /// </summary>
    [JsonPropertyName("interruptionsEnabled")]
    public bool? InterruptionsEnabled { get; set; }

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
