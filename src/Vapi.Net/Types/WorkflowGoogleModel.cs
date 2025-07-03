using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record WorkflowGoogleModel
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    [JsonPropertyName("model")]
    public required WorkflowGoogleModelModel Model { get; set; }

    /// <summary>
    /// This is the temperature of the model.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This is the max tokens of the model.
    /// </summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

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
