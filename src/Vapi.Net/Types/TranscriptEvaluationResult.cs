using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptEvaluationResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the word error rate: (substitutions + deletions + insertions)
    /// divided by the answer key's word count. Null when the answer key has no
    /// words.
    /// </summary>
    [JsonPropertyName("wer")]
    public double? Wer { get; set; }

    /// <summary>
    /// This is the number of answer-key words transcribed correctly.
    /// </summary>
    [JsonPropertyName("hits")]
    public required double Hits { get; set; }

    /// <summary>
    /// This is the number of answer-key words transcribed as a different word.
    /// </summary>
    [JsonPropertyName("substitutions")]
    public required double Substitutions { get; set; }

    /// <summary>
    /// This is the number of answer-key words missing from the transcript.
    /// </summary>
    [JsonPropertyName("deletions")]
    public required double Deletions { get; set; }

    /// <summary>
    /// This is the number of transcript words with no answer-key word.
    /// </summary>
    [JsonPropertyName("insertions")]
    public required double Insertions { get; set; }

    /// <summary>
    /// This is the number of words in the normalized answer key.
    /// </summary>
    [JsonPropertyName("referenceWordCount")]
    public required double ReferenceWordCount { get; set; }

    /// <summary>
    /// This is the number of words in the normalized transcript.
    /// </summary>
    [JsonPropertyName("hypothesisWordCount")]
    public required double HypothesisWordCount { get; set; }

    /// <summary>
    /// This is each key value's verdict, in answer-key order.
    /// </summary>
    [JsonPropertyName("keyValues")]
    public IEnumerable<TranscriptKeyValueResult> KeyValues { get; set; } =
        new List<TranscriptKeyValueResult>();

    /// <summary>
    /// This is each of the scenario's metric evaluations, in the scenario's order.
    /// </summary>
    [JsonPropertyName("evaluations")]
    public IEnumerable<TranscriptMetricEvaluationResult> Evaluations { get; set; } =
        new List<TranscriptMetricEvaluationResult>();

    /// <summary>
    /// This is false when a required evaluation failed or a required key value
    /// did not come through exactly.
    /// </summary>
    [JsonPropertyName("passed")]
    public required bool Passed { get; set; }

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
