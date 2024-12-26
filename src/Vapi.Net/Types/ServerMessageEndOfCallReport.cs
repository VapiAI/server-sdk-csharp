using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ServerMessageEndOfCallReport
{
    /// <summary>
    /// This is the phone number associated with the call.
    ///
    /// This matches one of the following:
    /// - `call.phoneNumber`,
    /// - `call.phoneNumberId`.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the reason the call ended. This can also be found at `call.endedReason` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("endedReason")]
    public required ServerMessageEndOfCallReportEndedReason EndedReason { get; set; }

    /// <summary>
    /// This is the cost of the call in USD. This can also be found at `call.cost` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("cost")]
    public double? Cost { get; set; }

    /// <summary>
    /// These are the costs of individual components of the call in USD. This can also be found at `call.costs` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("costs")]
    public IEnumerable<object>? Costs { get; set; }

    /// <summary>
    /// This is the ISO-8601 formatted timestamp of when the message was sent.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>
    /// These are the artifacts from the call. This can also be found at `call.artifact` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("artifact")]
    public required Artifact Artifact { get; set; }

    /// <summary>
    /// This is the assistant that is currently active. This is provided for convenience.
    ///
    /// This matches one of the following:
    /// - `call.assistant`,
    /// - `call.assistantId`,
    /// - `call.squad[n].assistant`,
    /// - `call.squad[n].assistantId`,
    /// - `call.squadId-&gt;[n].assistant`,
    /// - `call.squadId-&gt;[n].assistantId`.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the customer associated with the call.
    ///
    /// This matches one of the following:
    /// - `call.customer`,
    /// - `call.customerId`.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the call object.
    ///
    /// This matches what was returned in POST /call.
    ///
    /// Note: This might get stale during the call. To get the latest call object, especially after the call is ended, use GET /call/:id.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

    /// <summary>
    /// This is the analysis of the call. This can also be found at `call.analysis` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("analysis")]
    public required Analysis Analysis { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the call started. This can also be found at `call.startedAt` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the call ended. This can also be found at `call.endedAt` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("endedAt")]
    public DateTime? EndedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
