using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record WorkflowOpenAiModel
{
    /// <summary>
    /// This is the provider of the model (`openai`).
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "openai";

    /// <summary>
    /// This is the OpenAI model that will be used.
    ///
    /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.
    /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
    /// </summary>
    [JsonPropertyName("model")]
    public required WorkflowOpenAiModelModel Model { get; set; }

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
