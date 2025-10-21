using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MessageTarget
{
    /// <summary>
    /// This is the role of the message to target.
    ///
    /// If not specified, will find the position in the message history ignoring role (effectively `any`).
    /// </summary>
    [JsonPropertyName("role")]
    public MessageTargetRole? Role { get; set; }

    /// <summary>
    /// This is the position of the message to target.
    /// - Negative numbers: Count from end (-1 = most recent, -2 = second most recent)
    /// - 0: First/oldest message in history
    /// - Positive numbers: Specific position (0-indexed from start)
    ///
    /// @default -1 (most recent message)
    /// </summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

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
