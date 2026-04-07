using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageEndOfCallReport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
    /// </summary>
    [JsonPropertyName("type")]
    public required ServerMessageEndOfCallReportType Type { get; set; }

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
    /// This is the destination the call was transferred to, if the call was forwarded.
    /// This can also be found at `call.destination` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

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
    /// This is the chat object.
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat? Chat { get; set; }

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
    /// This is the compliance result of the call. This can also be found at `call.compliance` on GET /call/:id.
    /// </summary>
    [JsonPropertyName("compliance")]
    public Compliance? Compliance { get; set; }

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
