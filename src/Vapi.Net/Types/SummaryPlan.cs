using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SummaryPlan
{
    /// <summary>
    /// These are the messages used to generate the summary.
    ///
    /// @default: ```
    /// [
    ///   {
    ///     "role": "system",
    ///     "content": "You are an expert note-taker. You will be given a transcript of a call. Summarize the call in 2-3 sentences. DO NOT return anything except the summary."
    ///   },
    ///   {
    ///     "role": "user",
    ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n"
    ///   }
    /// ]```
    ///
    /// You can customize by providing any messages you want.
    ///
    /// Here are the template variables available:
    /// - {{transcript}}: The transcript of the call from `call.artifact.transcript`- {{systemPrompt}}: The system prompt of the call from `assistant.model.messages[type=system].content`
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    /// <summary>
    /// This determines whether a summary is generated and stored in `call.analysis.summary`. Defaults to true.
    ///
    /// Usage:
    /// - If you want to disable the summary, set this to false.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This is how long the request is tried before giving up. When request times out, `call.analysis.summary` will be empty.
    ///
    /// Usage:
    /// - To guarantee the summary is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.
    ///
    /// @default 5 seconds
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

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
