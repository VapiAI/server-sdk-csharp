using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CompliancePlan
{
    /// <summary>
    /// When this is enabled, no logs, recordings, or transcriptions will be stored. At the end of the call, you will still receive an end-of-call-report message to store on your server. Defaults to false.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    /// <summary>
    /// When this is enabled, the user will be restricted to use PCI-compliant providers, and no logs or transcripts are stored. At the end of the call, you will receive an end-of-call-report message to store on your server. Defaults to false.
    /// </summary>
    [JsonPropertyName("pciEnabled")]
    public bool? PciEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
