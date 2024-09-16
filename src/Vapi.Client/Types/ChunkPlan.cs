using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record ChunkPlan
{
    /// <summary>
    /// This determines whether the model output is chunked before being sent to the voice provider. Default `true`.
    ///
    /// Usage:
    ///
    /// - To rely on the voice provider's audio generation logic, set this to `false`.
    /// - If seeing issues with quality, set this to `true`.
    ///
    /// If disabled, Vapi-provided audio control tokens like <flush /> will not work.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This is the minimum number of characters in a chunk.
    ///
    /// Usage:
    ///
    /// - To increase quality, set this to a higher value.
    /// - To decrease latency, set this to a lower value.
    ///
    /// @default 30
    /// </summary>
    [JsonPropertyName("minCharacters")]
    public double? MinCharacters { get; set; }

    /// <summary>
    /// These are the punctuations that are considered valid boundaries for a chunk to be created.
    ///
    /// Usage:
    ///
    /// - To increase quality, constrain to fewer boundaries.
    /// - To decrease latency, enable all.
    ///
    /// Default is automatically set to balance the trade-off between quality and latency based on the provider.
    /// </summary>
    [JsonPropertyName("punctuationBoundaries")]
    public IEnumerable<ChunkPlanPunctuationBoundariesItem>? PunctuationBoundaries { get; set; }

    /// <summary>
    /// This is the plan for formatting the chunk before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("formatPlan")]
    public FormatPlan? FormatPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}