using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunControllerGenerateSuggestionsRequest
{
    /// <summary>
    /// Set to the string `true` to regenerate improvement suggestions even if they already exist.
    /// </summary>
    [JsonIgnore]
    public required string Force { get; set; }

    [JsonIgnore]
    public string? Persist { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
