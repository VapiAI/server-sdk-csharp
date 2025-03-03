using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackPlan
{
    /// <summary>
    /// This is the list of voices to fallback to in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("voices")]
    public IEnumerable<object> Voices { get; set; } = new List<object>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
