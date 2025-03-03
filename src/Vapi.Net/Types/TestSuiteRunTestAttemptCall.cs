using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuiteRunTestAttemptCall
{
    /// <summary>
    /// This is the artifact associated with the call.
    /// </summary>
    [JsonPropertyName("artifact")]
    public required Artifact Artifact { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
