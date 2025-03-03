using Vapi.Net.Core;

namespace Vapi.Net;

public record LogsGetRequest
{
    /// <summary>
    /// This is the type of the log.
    /// </summary>
    public LogsGetRequestType? Type { get; set; }

    /// <summary>
    /// This is the type of the webhook, given the log is from a webhook.
    /// </summary>
    public string? WebhookType { get; set; }

    /// <summary>
    /// This is the ID of the assistant.
    /// </summary>
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

    /// <summary>
    /// This is the page number to return. Defaults to 1.
    /// </summary>
    public double? Page { get; set; }

    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    public LogsGetRequestSortOrder? SortOrder { get; set; }

    /// <summary>
    /// This is the maximum number of items to return. Defaults to 100.
    /// </summary>
    public double? Limit { get; set; }

    /// <summary>
    /// This will return items where the createdAt is greater than the specified value.
    /// </summary>
    public DateTime? CreatedAtGt { get; set; }

    /// <summary>
    /// This will return items where the createdAt is less than the specified value.
    /// </summary>
    public DateTime? CreatedAtLt { get; set; }

    /// <summary>
    /// This will return items where the createdAt is greater than or equal to the specified value.
    /// </summary>
    public DateTime? CreatedAtGe { get; set; }

    /// <summary>
    /// This will return items where the createdAt is less than or equal to the specified value.
    /// </summary>
    public DateTime? CreatedAtLe { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is greater than the specified value.
    /// </summary>
    public DateTime? UpdatedAtGt { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is less than the specified value.
    /// </summary>
    public DateTime? UpdatedAtLt { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is greater than or equal to the specified value.
    /// </summary>
    public DateTime? UpdatedAtGe { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is less than or equal to the specified value.
    /// </summary>
    public DateTime? UpdatedAtLe { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
