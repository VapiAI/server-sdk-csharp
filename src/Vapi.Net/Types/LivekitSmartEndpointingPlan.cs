using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record LivekitSmartEndpointingPlan
{
    /// <summary>
    /// This is the provider for the smart endpointing plan.
    /// </summary>
    [JsonPropertyName("provider")]
    public required LivekitSmartEndpointingPlanProvider Provider { get; set; }

    /// <summary>
    /// This expression describes how long the bot will wait to start speaking based on the likelihood that the user has reached an endpoint.
    ///
    /// This is a millisecond valued function. It maps probabilities (real numbers on [0,1]) to milliseconds that the bot should wait before speaking ([0, \infty]). Any negative values that are returned are set to zero (the bot can't start talking in the past).
    ///
    /// A probability of zero represents very high confidence that the caller has stopped speaking, and would like the bot to speak to them. A probability of one represents very high confidence that the caller is still speaking.
    ///
    /// Under the hood, this is parsed into a mathjs expression. Whatever you use to write your expression needs to be valid with respect to mathjs
    ///
    /// @default "70 + 4000 * x"
    /// </summary>
    [JsonPropertyName("waitFunction")]
    public string? WaitFunction { get; set; }

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
