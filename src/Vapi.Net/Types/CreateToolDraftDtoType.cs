using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateToolDraftDtoTypeSerializer))]
public enum CreateToolDraftDtoType
{
    [EnumMember(Value = "dtmf")]
    Dtmf,

    [EnumMember(Value = "endCall")]
    EndCall,

    [EnumMember(Value = "knowledgeBase")]
    KnowledgeBase,

    [EnumMember(Value = "transferCall")]
    TransferCall,

    [EnumMember(Value = "transferCancel")]
    TransferCancel,

    [EnumMember(Value = "transferSuccessful")]
    TransferSuccessful,

    [EnumMember(Value = "handoff")]
    Handoff,

    [EnumMember(Value = "output")]
    Output,

    [EnumMember(Value = "voicemail")]
    Voicemail,

    [EnumMember(Value = "query")]
    Query,

    [EnumMember(Value = "sms")]
    Sms,

    [EnumMember(Value = "sipRequest")]
    SipRequest,

    [EnumMember(Value = "function")]
    Function,

    [EnumMember(Value = "mcp")]
    Mcp,

    [EnumMember(Value = "apiRequest")]
    ApiRequest,

    [EnumMember(Value = "code")]
    Code,

    [EnumMember(Value = "bash")]
    Bash,

    [EnumMember(Value = "computer")]
    Computer,

    [EnumMember(Value = "textEditor")]
    TextEditor,

    [EnumMember(Value = "google.calendar.event.create")]
    GoogleCalendarEventCreate,

    [EnumMember(Value = "google.calendar.availability.check")]
    GoogleCalendarAvailabilityCheck,

    [EnumMember(Value = "google.sheets.row.append")]
    GoogleSheetsRowAppend,

    [EnumMember(Value = "slack.message.send")]
    SlackMessageSend,

    [EnumMember(Value = "gohighlevel.calendar.event.create")]
    GohighlevelCalendarEventCreate,

    [EnumMember(Value = "gohighlevel.calendar.availability.check")]
    GohighlevelCalendarAvailabilityCheck,

    [EnumMember(Value = "gohighlevel.contact.create")]
    GohighlevelContactCreate,

    [EnumMember(Value = "gohighlevel.contact.get")]
    GohighlevelContactGet,

    [EnumMember(Value = "make")]
    Make,

    [EnumMember(Value = "ghl")]
    Ghl,
}

internal class CreateToolDraftDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateToolDraftDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateToolDraftDtoType
    > _stringToEnum = new()
    {
        { "dtmf", CreateToolDraftDtoType.Dtmf },
        { "endCall", CreateToolDraftDtoType.EndCall },
        { "knowledgeBase", CreateToolDraftDtoType.KnowledgeBase },
        { "transferCall", CreateToolDraftDtoType.TransferCall },
        { "transferCancel", CreateToolDraftDtoType.TransferCancel },
        { "transferSuccessful", CreateToolDraftDtoType.TransferSuccessful },
        { "handoff", CreateToolDraftDtoType.Handoff },
        { "output", CreateToolDraftDtoType.Output },
        { "voicemail", CreateToolDraftDtoType.Voicemail },
        { "query", CreateToolDraftDtoType.Query },
        { "sms", CreateToolDraftDtoType.Sms },
        { "sipRequest", CreateToolDraftDtoType.SipRequest },
        { "function", CreateToolDraftDtoType.Function },
        { "mcp", CreateToolDraftDtoType.Mcp },
        { "apiRequest", CreateToolDraftDtoType.ApiRequest },
        { "code", CreateToolDraftDtoType.Code },
        { "bash", CreateToolDraftDtoType.Bash },
        { "computer", CreateToolDraftDtoType.Computer },
        { "textEditor", CreateToolDraftDtoType.TextEditor },
        { "google.calendar.event.create", CreateToolDraftDtoType.GoogleCalendarEventCreate },
        {
            "google.calendar.availability.check",
            CreateToolDraftDtoType.GoogleCalendarAvailabilityCheck
        },
        { "google.sheets.row.append", CreateToolDraftDtoType.GoogleSheetsRowAppend },
        { "slack.message.send", CreateToolDraftDtoType.SlackMessageSend },
        {
            "gohighlevel.calendar.event.create",
            CreateToolDraftDtoType.GohighlevelCalendarEventCreate
        },
        {
            "gohighlevel.calendar.availability.check",
            CreateToolDraftDtoType.GohighlevelCalendarAvailabilityCheck
        },
        { "gohighlevel.contact.create", CreateToolDraftDtoType.GohighlevelContactCreate },
        { "gohighlevel.contact.get", CreateToolDraftDtoType.GohighlevelContactGet },
        { "make", CreateToolDraftDtoType.Make },
        { "ghl", CreateToolDraftDtoType.Ghl },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateToolDraftDtoType,
        string
    > _enumToString = new()
    {
        { CreateToolDraftDtoType.Dtmf, "dtmf" },
        { CreateToolDraftDtoType.EndCall, "endCall" },
        { CreateToolDraftDtoType.KnowledgeBase, "knowledgeBase" },
        { CreateToolDraftDtoType.TransferCall, "transferCall" },
        { CreateToolDraftDtoType.TransferCancel, "transferCancel" },
        { CreateToolDraftDtoType.TransferSuccessful, "transferSuccessful" },
        { CreateToolDraftDtoType.Handoff, "handoff" },
        { CreateToolDraftDtoType.Output, "output" },
        { CreateToolDraftDtoType.Voicemail, "voicemail" },
        { CreateToolDraftDtoType.Query, "query" },
        { CreateToolDraftDtoType.Sms, "sms" },
        { CreateToolDraftDtoType.SipRequest, "sipRequest" },
        { CreateToolDraftDtoType.Function, "function" },
        { CreateToolDraftDtoType.Mcp, "mcp" },
        { CreateToolDraftDtoType.ApiRequest, "apiRequest" },
        { CreateToolDraftDtoType.Code, "code" },
        { CreateToolDraftDtoType.Bash, "bash" },
        { CreateToolDraftDtoType.Computer, "computer" },
        { CreateToolDraftDtoType.TextEditor, "textEditor" },
        { CreateToolDraftDtoType.GoogleCalendarEventCreate, "google.calendar.event.create" },
        {
            CreateToolDraftDtoType.GoogleCalendarAvailabilityCheck,
            "google.calendar.availability.check"
        },
        { CreateToolDraftDtoType.GoogleSheetsRowAppend, "google.sheets.row.append" },
        { CreateToolDraftDtoType.SlackMessageSend, "slack.message.send" },
        {
            CreateToolDraftDtoType.GohighlevelCalendarEventCreate,
            "gohighlevel.calendar.event.create"
        },
        {
            CreateToolDraftDtoType.GohighlevelCalendarAvailabilityCheck,
            "gohighlevel.calendar.availability.check"
        },
        { CreateToolDraftDtoType.GohighlevelContactCreate, "gohighlevel.contact.create" },
        { CreateToolDraftDtoType.GohighlevelContactGet, "gohighlevel.contact.get" },
        { CreateToolDraftDtoType.Make, "make" },
        { CreateToolDraftDtoType.Ghl, "ghl" },
    };

    public override CreateToolDraftDtoType Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        CreateToolDraftDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateToolDraftDtoType ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        CreateToolDraftDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
