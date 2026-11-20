using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingSuiteUpdateDto
{
    /// <summary>
    /// A new key for each edit. Replaying an applied key changes nothing and returns the current suite. A suite remembers its last 50 keys, so never reuse one.
    /// </summary>
    [JsonPropertyName("patchKey")]
    public required string PatchKey { get; set; }

    /// <summary>
    /// Simulations to take out of the suite. They are unlinked, not deleted.
    /// </summary>
    [JsonPropertyName("removeSimulationIds")]
    public IEnumerable<string>? RemoveSimulationIds { get; set; }

    /// <summary>
    /// Simulations to rewrite in place, at most one edit per simulation: put every change for a simulation in one instruction.
    /// </summary>
    [JsonPropertyName("edits")]
    public IEnumerable<SimulationOnboardingSuiteEditDto>? Edits { get; set; }

    /// <summary>
    /// Regenerate the scenarios that failed or did not fit when the suite was generated.
    /// </summary>
    [JsonPropertyName("retryFailed")]
    public bool? RetryFailed { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
