using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseOutputText
{
    /// <summary>
    /// Annotations in the text output
    /// </summary>
    [JsonPropertyName("annotations")]
    public IEnumerable<object> Annotations { get; set; } = new List<object>();

    /// <summary>
    /// The text output from the model
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>
    /// The type of the output text
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "output_text";

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
