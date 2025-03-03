using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageResponseAssistantRequest
{
    /// <summary>
    /// This is the destination to transfer the inbound call to. This will immediately transfer without using any assistants.
    ///
    /// If this is sent, `assistantId`, `assistant`, `squadId`, and `squad` are ignored.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use a transient assistant, use `assistant` instead.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
    ///
    /// If you're unsure why you're getting an invalid assistant, try logging your response and send the JSON blob to POST /assistant which will return the validation errors.
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
    /// This is the error if the call shouldn't be accepted. This is spoken to the customer.
    ///
    /// If this is sent, `assistantId`, `assistant`, `squadId`, `squad`, and `destination` are ignored.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
