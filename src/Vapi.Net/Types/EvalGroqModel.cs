using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EvalGroqModel
{
    /// <summary>
    /// This is the provider of the model (`groq`).
    /// </summary>
    [JsonPropertyName("provider")]
    public required EvalGroqModelProvider Provider { get; set; }

    /// <summary>
    /// This is the name of the model. Ex. gpt-4o
    /// </summary>
    [JsonPropertyName("model")]
    public required EvalGroqModelModel Model { get; set; }

    /// <summary>
    /// This is the temperature of the model. For LLM-as-a-judge, it's recommended to set it between 0 - 0.3 to avoid hallucinations and ensure the model judges the output correctly based on the instructions.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This is the max tokens of the model.
    /// If your Judge instructions return `true` or `false` takes only 1 token (as per the OpenAI Tokenizer), and therefore is recommended to set it to a low number to force the model to return a short response.
    /// </summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

    /// <summary>
    /// These are the messages which will instruct the AI Judge on how to evaluate the assistant message.
    /// The LLM-Judge must respond with "pass" or "fail" to indicate if the assistant message passes the eval.
    ///
    /// To access the messages in the mock conversation, use the LiquidJS variable `{{messages}}`.
    /// The assistant message to be evaluated will be passed as the last message in the `messages` array and can be accessed using `{{messages[-1]}}`.
    ///
    /// It is recommended to use the system message to instruct the LLM how to evaluate the assistant message, and then use the first user message to pass the assistant message to be evaluated.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object> Messages { get; set; } = new List<object>();

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
