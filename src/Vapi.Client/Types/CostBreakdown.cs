using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record CostBreakdown
{
    /// <summary>
    /// This is the cost of the transport provider, like Twilio or Vonage.
    /// </summary>
    [JsonPropertyName("transport")]
    public double? Transport { get; set; }

    /// <summary>
    /// This is the cost of the speech-to-text service.
    /// </summary>
    [JsonPropertyName("stt")]
    public double? Stt { get; set; }

    /// <summary>
    /// This is the cost of the language model.
    /// </summary>
    [JsonPropertyName("llm")]
    public double? Llm { get; set; }

    /// <summary>
    /// This is the cost of the text-to-speech service.
    /// </summary>
    [JsonPropertyName("tts")]
    public double? Tts { get; set; }

    /// <summary>
    /// This is the cost of Vapi.
    /// </summary>
    [JsonPropertyName("vapi")]
    public double? Vapi { get; set; }

    /// <summary>
    /// This is the total cost of the call.
    /// </summary>
    [JsonPropertyName("total")]
    public double? Total { get; set; }

    /// <summary>
    /// This is the LLM prompt tokens used for the call.
    /// </summary>
    [JsonPropertyName("llmPromptTokens")]
    public double? LlmPromptTokens { get; set; }

    /// <summary>
    /// This is the LLM completion tokens used for the call.
    /// </summary>
    [JsonPropertyName("llmCompletionTokens")]
    public double? LlmCompletionTokens { get; set; }

    /// <summary>
    /// This is the TTS characters used for the call.
    /// </summary>
    [JsonPropertyName("ttsCharacters")]
    public double? TtsCharacters { get; set; }

    /// <summary>
    /// This is the cost of the analysis.
    /// </summary>
    [JsonPropertyName("analysisCostBreakdown")]
    public AnalysisCostBreakdown? AnalysisCostBreakdown { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
