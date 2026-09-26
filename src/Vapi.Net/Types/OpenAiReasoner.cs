using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiReasoner : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The reasoner uses OpenAI. Omit to use OpenAI.
    /// </summary>
    [JsonPropertyName("provider")]
    public OpenAiReasonerProvider? Provider { get; set; }

    /// <summary>
    /// The delegated reasoning model. Omit to use GPT-5.6 Terra.
    /// </summary>
    [JsonPropertyName("model")]
    public OpenAiReasonerModel? Model { get; set; }

    /// <summary>
    /// Higher effort can increase response time. Omit to use low.
    /// </summary>
    [JsonPropertyName("reasoningEffort")]
    public OpenAiReasonerReasoningEffort? ReasoningEffort { get; set; }

    /// <summary>
    /// Complete reasoner instructions. An explicit empty string is preserved.
    /// Omit to use Vapi's default reasoner instructions. No behavioral instructions
    /// are appended to a custom prompt.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

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
