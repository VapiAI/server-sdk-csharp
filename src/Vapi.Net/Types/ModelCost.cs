using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ModelCost : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the model that was used during the call.
    ///
    /// This matches one of the following:
    /// - `call.assistant.model`,
    /// - `call.assistantId-&gt;model`,
    /// - `call.squad[n].assistant.model`,
    /// - `call.squad[n].assistantId-&gt;model`,
    /// - `call.squadId-&gt;[n].assistant.model`,
    /// - `call.squadId-&gt;[n].assistantId-&gt;model`.
    /// </summary>
    [JsonPropertyName("model")]
    public object Model { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the number of prompt tokens used in the call. These should be total prompt tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
    /// </summary>
    [JsonPropertyName("promptTokens")]
    public required double PromptTokens { get; set; }

    /// <summary>
    /// This is the number of completion tokens generated in the call. These should be total completion tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
    /// </summary>
    [JsonPropertyName("completionTokens")]
    public required double CompletionTokens { get; set; }

    /// <summary>
    /// This is the number of cached prompt tokens used in the call. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
    /// </summary>
    [JsonPropertyName("cachedPromptTokens")]
    public double? CachedPromptTokens { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

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
