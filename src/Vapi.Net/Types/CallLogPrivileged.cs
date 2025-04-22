using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CallLogPrivileged
{
    /// <summary>
    /// This is the unique identifier for the call.
    /// </summary>
    [JsonPropertyName("callId")]
    public required string CallId { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this call log belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the log message associated with the call.
    /// </summary>
    [JsonPropertyName("log")]
    public required string Log { get; set; }

    /// <summary>
    /// This is the level of the log message.
    /// </summary>
    [JsonPropertyName("level")]
    public required CallLogPrivilegedLevel Level { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the log was created.
    /// </summary>
    [JsonPropertyName("time")]
    public required DateTime Time { get; set; }

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
