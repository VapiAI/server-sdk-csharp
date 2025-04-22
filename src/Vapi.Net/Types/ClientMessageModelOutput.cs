using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageModelOutput
{
    /// <summary>
    /// This is the type of the message. "model-output" is sent as the model outputs tokens.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "model-output";

    /// <summary>
    /// This is the output of the model. It can be a token or tool call.
    /// </summary>
    [JsonPropertyName("output")]
    public object Output { get; set; } = new Dictionary<string, object?>();

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
