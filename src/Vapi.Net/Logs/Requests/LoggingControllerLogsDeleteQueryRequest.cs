using Vapi.Net.Core;

namespace Vapi.Net;

public record LoggingControllerLogsDeleteQueryRequest
{
    /// <summary>
    /// This is the type of the log.
    /// </summary>
    public LoggingControllerLogsDeleteQueryRequestType? Type { get; set; }

    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the ID of the phone number.
    /// </summary>
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the ID of the customer.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// This is the ID of the squad.
    /// </summary>
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the ID of the call.
    /// </summary>
    public string? CallId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
