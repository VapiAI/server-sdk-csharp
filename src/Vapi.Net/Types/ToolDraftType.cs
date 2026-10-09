using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolDraftTypeSerializer))]
public enum ToolDraftType
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

internal class ToolDraftTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolDraftType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolDraftType
    > _stringToEnum = new()
    {
        { "dtmf", ToolDraftType.Dtmf },
        { "endCall", ToolDraftType.EndCall },
        { "knowledgeBase", ToolDraftType.KnowledgeBase },
        { "transferCall", ToolDraftType.TransferCall },
        { "transferCancel", ToolDraftType.TransferCancel },
        { "transferSuccessful", ToolDraftType.TransferSuccessful },
        { "handoff", ToolDraftType.Handoff },
        { "output", ToolDraftType.Output },
        { "voicemail", ToolDraftType.Voicemail },
        { "query", ToolDraftType.Query },
        { "sms", ToolDraftType.Sms },
        { "sipRequest", ToolDraftType.SipRequest },
        { "function", ToolDraftType.Function },
        { "mcp", ToolDraftType.Mcp },
        { "apiRequest", ToolDraftType.ApiRequest },
        { "code", ToolDraftType.Code },
        { "bash", ToolDraftType.Bash },
        { "computer", ToolDraftType.Computer },
        { "textEditor", ToolDraftType.TextEditor },
        { "google.calendar.event.create", ToolDraftType.GoogleCalendarEventCreate },
        { "google.calendar.availability.check", ToolDraftType.GoogleCalendarAvailabilityCheck },
        { "google.sheets.row.append", ToolDraftType.GoogleSheetsRowAppend },
        { "slack.message.send", ToolDraftType.SlackMessageSend },
        { "gohighlevel.calendar.event.create", ToolDraftType.GohighlevelCalendarEventCreate },
        {
            "gohighlevel.calendar.availability.check",
            ToolDraftType.GohighlevelCalendarAvailabilityCheck
        },
        { "gohighlevel.contact.create", ToolDraftType.GohighlevelContactCreate },
        { "gohighlevel.contact.get", ToolDraftType.GohighlevelContactGet },
        { "make", ToolDraftType.Make },
        { "ghl", ToolDraftType.Ghl },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolDraftType,
        string
    > _enumToString = new()
    {
        { ToolDraftType.Dtmf, "dtmf" },
        { ToolDraftType.EndCall, "endCall" },
        { ToolDraftType.KnowledgeBase, "knowledgeBase" },
        { ToolDraftType.TransferCall, "transferCall" },
        { ToolDraftType.TransferCancel, "transferCancel" },
        { ToolDraftType.TransferSuccessful, "transferSuccessful" },
        { ToolDraftType.Handoff, "handoff" },
        { ToolDraftType.Output, "output" },
        { ToolDraftType.Voicemail, "voicemail" },
        { ToolDraftType.Query, "query" },
        { ToolDraftType.Sms, "sms" },
        { ToolDraftType.SipRequest, "sipRequest" },
        { ToolDraftType.Function, "function" },
        { ToolDraftType.Mcp, "mcp" },
        { ToolDraftType.ApiRequest, "apiRequest" },
        { ToolDraftType.Code, "code" },
        { ToolDraftType.Bash, "bash" },
        { ToolDraftType.Computer, "computer" },
        { ToolDraftType.TextEditor, "textEditor" },
        { ToolDraftType.GoogleCalendarEventCreate, "google.calendar.event.create" },
        { ToolDraftType.GoogleCalendarAvailabilityCheck, "google.calendar.availability.check" },
        { ToolDraftType.GoogleSheetsRowAppend, "google.sheets.row.append" },
        { ToolDraftType.SlackMessageSend, "slack.message.send" },
        { ToolDraftType.GohighlevelCalendarEventCreate, "gohighlevel.calendar.event.create" },
        {
            ToolDraftType.GohighlevelCalendarAvailabilityCheck,
            "gohighlevel.calendar.availability.check"
        },
        { ToolDraftType.GohighlevelContactCreate, "gohighlevel.contact.create" },
        { ToolDraftType.GohighlevelContactGet, "gohighlevel.contact.get" },
        { ToolDraftType.Make, "make" },
        { ToolDraftType.Ghl, "ghl" },
    };

    public override ToolDraftType Read(
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
        ToolDraftType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolDraftType ReadAsPropertyName(
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
        ToolDraftType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
