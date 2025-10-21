using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CompliancePlan
{
    /// <summary>
    /// When this is enabled, no logs, recordings, or transcriptions will be stored.
    /// At the end of the call, you will still receive an end-of-call-report message to store on your server. Defaults to false.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    /// <summary>
    /// When this is enabled, the user will be restricted to use PCI-compliant providers, and no logs or transcripts are stored.
    /// At the end of the call, you will receive an end-of-call-report message to store on your server. Defaults to false.
    /// </summary>
    [JsonPropertyName("pciEnabled")]
    public bool? PciEnabled { get; set; }

    /// <summary>
    /// This is the security filter plan for the assistant. It allows filtering of transcripts for security threats before sending to LLM.
    /// </summary>
    [JsonPropertyName("securityFilterPlan")]
    public SecurityFilterPlan? SecurityFilterPlan { get; set; }

    [JsonPropertyName("recordingConsentPlan")]
    public object? RecordingConsentPlan { get; set; }

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
