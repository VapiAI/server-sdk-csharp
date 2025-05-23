using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageEndOfCallReport
{
    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "end-of-call-report";

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
    /// This is the timestamp of the message.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double? Timestamp { get; set; }

    /// <summary>
    /// These are the artifacts from the call. This can also be found at `call.artifact` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("artifact")]
    public required Artifact Artifact { get; set; }

    /// <summary>
    /// This is the assistant that the message is associated with.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the customer that the message is associated with.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the call that the message is associated with.
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
