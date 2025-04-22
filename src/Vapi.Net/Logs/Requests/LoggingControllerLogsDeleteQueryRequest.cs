using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record LoggingControllerLogsDeleteQueryRequest
{
    /// <summary>
    /// This is the type of the log.
    /// </summary>
    [JsonIgnore]
    public LoggingControllerLogsDeleteQueryRequestType? Type { get; set; }

    [JsonIgnore]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the ID of the phone number.
    /// </summary>
    [JsonIgnore]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the ID of the customer.
    /// </summary>
    [JsonIgnore]
    public string? CustomerId { get; set; }

    /// <summary>
    /// This is the ID of the squad.
    /// </summary>
    [JsonIgnore]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the ID of the call.
    /// </summary>
    [JsonIgnore]
    public string? CallId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
