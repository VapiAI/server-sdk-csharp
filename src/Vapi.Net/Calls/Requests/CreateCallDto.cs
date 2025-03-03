using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateCallDto
{
    /// <summary>
    /// This is the name of the call. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use a transient assistant, use `assistant` instead.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// These are the overrides for the `assistant` or `assistantId`'s settings and template variables.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// This is the squad that will be used for the call. To use a transient squad, use `squad` instead.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is a squad that will be used for the call. To use an existing squad, use `squadId` instead.
    /// </summary>
    [JsonPropertyName("squad")]
    public CreateSquadDto? Squad { get; set; }

    /// <summary>
    /// This is the phone number that will be used for the call. To use a transient number, use `phoneNumber` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the phone number that will be used for the call. To use an existing number, use `phoneNumberId` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public ImportTwilioPhoneNumberDto? PhoneNumber { get; set; }

    /// <summary>
    /// This is the customer that will be called. To call a transient customer , use `customer` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// This is the customer that will be called. To call an existing customer, use `customerId` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
