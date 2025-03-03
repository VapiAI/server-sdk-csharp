using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

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

    /// <summary>
    /// This determines if a customer speech is considered done (endpointing) using a Vapi custom-trained model on customer's speech. This is good for middle-of-thought detection.
    ///
    /// Once an endpoint is triggered, the request is sent to `assistant.model`.
    ///
    /// Usage:
    /// - If your conversations are long-form and you want assistant to wait smartly even if customer pauses for a bit to think, you can use this instead.
    ///
    /// This overrides `transcriptionEndpointingPlan`.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("smartEndpointingEnabled")]
    public bool? SmartEndpointingEnabled { get; set; }

    /// <summary>
    /// These are the custom endpointing rules to set an endpointing timeout based on a regex on the customer's speech or the assistant's last message.
    ///
    /// Usage:
    /// - If you have yes/no questions like "are you interested in a loan?", you can set a shorter timeout.
    /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.
    /// - If you want to wait longer while customer is enumerating a list of numbers, you can set a longer timeout.
    ///
    /// These override `transcriptionEndpointingPlan` and `smartEndpointingEnabled` when a rule is matched.
    ///
    /// The rules are evaluated in order and the first one that matches will be used.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("customEndpointingRules")]
    public IEnumerable<object>? CustomEndpointingRules { get; set; }

    /// <summary>
    /// This determines how a customer speech is considered done (endpointing) using the transcription of customer's speech.
    ///
    /// Once an endpoint is triggered, the request is sent to `assistant.model`.
    /// </summary>
    [JsonPropertyName("transcriptionEndpointingPlan")]
    public TranscriptionEndpointingPlan? TranscriptionEndpointingPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
