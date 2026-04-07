using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptionEndpointingPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The minimum number of seconds to wait after transcription ending with punctuation before sending a request to the model. Defaults to 0.1.
    ///
    /// This setting exists because the transcriber punctuates the transcription when it's more confident that customer has completed a thought.
    ///
    /// @default 0.1
    /// </summary>
    [JsonPropertyName("onPunctuationSeconds")]
    public double? OnPunctuationSeconds { get; set; }

    /// <summary>
    /// The minimum number of seconds to wait after transcription ending without punctuation before sending a request to the model. Defaults to 1.5.
    ///
    /// This setting exists to catch the cases where the transcriber was not confident enough to punctuate the transcription, but the customer is done and has been silent for a long time.
    ///
    /// @default 1.5
    /// </summary>
    [JsonPropertyName("onNoPunctuationSeconds")]
    public double? OnNoPunctuationSeconds { get; set; }

    /// <summary>
    /// The minimum number of seconds to wait after transcription ending with a number before sending a request to the model. Defaults to 0.4.
    ///
    /// This setting exists because the transcriber will sometimes punctuate the transcription ending with a number, even though the customer hasn't uttered the full number. This happens commonly for long numbers when the customer reads the number in chunks.
    ///
    /// @default 0.5
    /// </summary>
    [JsonPropertyName("onNumberSeconds")]
    public double? OnNumberSeconds { get; set; }

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
