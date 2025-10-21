using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record RecordingConsent
{
    /// <summary>
    /// This is the type of recording consent.
    /// </summary>
    [JsonPropertyName("type")]
    public object Type { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the date and time the recording consent was granted.
    /// If not specified, it means the recording consent was not granted.
    /// </summary>
    [JsonPropertyName("grantedAt")]
    public DateTime? GrantedAt { get; set; }

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
