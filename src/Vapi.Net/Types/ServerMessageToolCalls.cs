using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ServerMessageToolCalls
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
    /// This is the list of tools calls that the model is requesting along with the original tool configuration.
    /// </summary>
    [JsonPropertyName("toolWithToolCallList")]
    public IEnumerable<
        OneOf<
            FunctionToolWithToolCall,
            GhlToolWithToolCall,
            MakeToolWithToolCall,
            object,
            object,
            object
        >
    > ToolWithToolCallList { get; set; } =
        new List<
            OneOf<
                FunctionToolWithToolCall,
                GhlToolWithToolCall,
                MakeToolWithToolCall,
                object,
                object,
                object
            >
        >();

    /// <summary>
    /// This is the ISO-8601 formatted timestamp of when the message was sent.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>
    /// This is a live version of the `call.artifact`.
    ///
    /// This matches what is stored on `call.artifact` after the call.
    /// </summary>
    [JsonPropertyName("artifact")]
    public Artifact? Artifact { get; set; }

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
    /// This is the list of tool calls that the model is requesting.
    /// </summary>
    [JsonPropertyName("toolCallList")]
    public IEnumerable<ToolCall> ToolCallList { get; set; } = new List<ToolCall>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
