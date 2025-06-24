using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Log
{
    /// <summary>
    /// This is the timestamp at which the log was written.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this log belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the type of the log.
    /// </summary>
    [JsonPropertyName("type")]
    public required LogType Type { get; set; }

    /// <summary>
    /// This is the type of the webhook, given the log is from a webhook.
    /// </summary>
    [JsonPropertyName("webhookType")]
    public string? WebhookType { get; set; }

    /// <summary>
    /// This is the specific resource, relevant only to API logs.
    /// </summary>
    [JsonPropertyName("resource")]
    public LogResource? Resource { get; set; }

    /// <summary>
    /// 'This is how long the request took.
    /// </summary>
    [JsonPropertyName("requestDurationSeconds")]
    public double? RequestDurationSeconds { get; set; }

    /// <summary>
    /// This is the timestamp at which the request began.
    /// </summary>
    [JsonPropertyName("requestStartedAt")]
    public string? RequestStartedAt { get; set; }

    /// <summary>
    /// This is the timestamp at which the request finished.
    /// </summary>
    [JsonPropertyName("requestFinishedAt")]
    public string? RequestFinishedAt { get; set; }

    /// <summary>
    /// This is the body of the request.
    /// </summary>
    [JsonPropertyName("requestBody")]
    public object? RequestBody { get; set; }

    /// <summary>
    /// This is the request method.
    /// </summary>
    [JsonPropertyName("requestHttpMethod")]
    public LogRequestHttpMethod? RequestHttpMethod { get; set; }

    /// <summary>
    /// This is the request URL.
    /// </summary>
    [JsonPropertyName("requestUrl")]
    public string? RequestUrl { get; set; }

    /// <summary>
    /// This is the request path.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>
    /// This is the request query.
    /// </summary>
    [JsonPropertyName("requestQuery")]
    public string? RequestQuery { get; set; }

    /// <summary>
    /// This the HTTP status code of the response.
    /// </summary>
    [JsonPropertyName("responseHttpCode")]
    public double? ResponseHttpCode { get; set; }

    /// <summary>
    /// This is the request IP address.
    /// </summary>
    [JsonPropertyName("requestIpAddress")]
    public string? RequestIpAddress { get; set; }

    /// <summary>
    /// This is the origin of the request
    /// </summary>
    [JsonPropertyName("requestOrigin")]
    public string? RequestOrigin { get; set; }

    /// <summary>
    /// This is the body of the response.
    /// </summary>
    [JsonPropertyName("responseBody")]
    public object? ResponseBody { get; set; }

    /// <summary>
    /// These are the headers of the request.
    /// </summary>
    [JsonPropertyName("requestHeaders")]
    public object? RequestHeaders { get; set; }

    /// <summary>
    /// This is the error, if one occurred.
    /// </summary>
    [JsonPropertyName("error")]
    public Error? Error { get; set; }

    /// <summary>
    /// This is the ID of the assistant.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the ID of the phone number.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the ID of the customer.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// This is the ID of the squad.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the ID of the call.
    /// </summary>
    [JsonPropertyName("callId")]
    public string? CallId { get; set; }

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
