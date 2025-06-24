using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record KeypadInputPlan
{
    /// <summary>
    /// This keeps track of whether the user has enabled keypad input.
    /// By default, it is off.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This is the time in seconds to wait before processing the input.
    /// If the input is not received within this time, the input will be ignored.
    /// If set to "off", the input will be processed when the user enters a delimiter or immediately if no delimiter is used.
    ///
    /// @default 2
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// This is the delimiter(s) that will be used to process the input.
    /// Can be '#', '*', or an empty array.
    /// </summary>
    [JsonPropertyName("delimiters")]
    public KeypadInputPlanDelimiters? Delimiters { get; set; }

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
