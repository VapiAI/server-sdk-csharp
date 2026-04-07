using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CompliancePlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false. Only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively. This setting is only honored if the organization is on an Enterprise subscription or has purchased the HIPAA add-on.
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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
