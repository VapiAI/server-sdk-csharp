using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record StartSpeakingPlan
{
    /// <summary>
    /// This is how long assistant waits before speaking. Defaults to 0.4.
    ///
    /// This is the minimum it will wait but if there is latency is the pipeline, this minimum will be exceeded. This is intended as a stopgap in case the pipeline is moving too fast.
    ///
    /// Example:
    /// - If model generates tokens and voice generates bytes within 100ms, the pipeline still waits 300ms before outputting speech.
    ///
    /// Usage:
    /// - If the customer is taking long pauses, set this to a higher value.
    /// - If the assistant is accidentally jumping in too much, set this to a higher value.
    ///
    /// @default 0.4
    /// </summary>
    [JsonPropertyName("waitSeconds")]
    public double? WaitSeconds { get; set; }

    [JsonPropertyName("smartEndpointingEnabled")]
    public OneOf<bool, string>? SmartEndpointingEnabled { get; set; }

    /// <summary>
    /// This is the plan for smart endpointing. Pick between Vapi smart endpointing or LiveKit smart endpointing (or nothing). We strongly recommend using livekit endpointing when working in English. LiveKit endpointing is not supported in other languages, yet.
    ///
    /// If this is set, it will override and take precedence over `transcriptionEndpointingPlan`.
    /// This plan will still be overridden by any matching `customEndpointingRules`.
    /// </summary>
    [JsonPropertyName("smartEndpointingPlan")]
    public OneOf<
        VapiSmartEndpointingPlan,
        LivekitSmartEndpointingPlan,
        CustomEndpointingModelSmartEndpointingPlan
    >? SmartEndpointingPlan { get; set; }

    /// <summary>
    /// These are the custom endpointing rules to set an endpointing timeout based on a regex on the customer's speech or the assistant's last message.
    ///
    /// Usage:
    /// - If you have yes/no questions like "are you interested in a loan?", you can set a shorter timeout.
    /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.
    /// - If you want to wait longer while customer is enumerating a list of numbers, you can set a longer timeout.
    ///
    /// These rules have the highest precedence and will override both `smartEndpointingPlan` and `transcriptionEndpointingPlan` when a rule is matched.
    ///
    /// The rules are evaluated in order and the first one that matches will be used.
    ///
    /// Order of precedence for endpointing:
    /// 1. customEndpointingRules (if any match)
    /// 2. smartEndpointingPlan (if set)
    /// 3. transcriptionEndpointingPlan
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("customEndpointingRules")]
    public IEnumerable<object>? CustomEndpointingRules { get; set; }

    /// <summary>
    /// This determines how a customer speech is considered done (endpointing) using the transcription of customer's speech.
    ///
    /// Once an endpoint is triggered, the request is sent to `assistant.model`.
    ///
    /// Note: This plan is only used if `smartEndpointingPlan` is not set. If both are provided, `smartEndpointingPlan` takes precedence.
    /// This plan will also be overridden by any matching `customEndpointingRules`.
    /// </summary>
    [JsonPropertyName("transcriptionEndpointingPlan")]
    public TranscriptionEndpointingPlan? TranscriptionEndpointingPlan { get; set; }

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
