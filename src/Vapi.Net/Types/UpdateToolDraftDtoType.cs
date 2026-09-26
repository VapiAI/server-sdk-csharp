using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateToolDraftDtoTypeSerializer))]
public enum UpdateToolDraftDtoType
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

internal class UpdateToolDraftDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateToolDraftDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateToolDraftDtoType
    > _stringToEnum = new()
    {
        { "dtmf", UpdateToolDraftDtoType.Dtmf },
        { "endCall", UpdateToolDraftDtoType.EndCall },
        { "knowledgeBase", UpdateToolDraftDtoType.KnowledgeBase },
        { "transferCall", UpdateToolDraftDtoType.TransferCall },
        { "transferCancel", UpdateToolDraftDtoType.TransferCancel },
        { "transferSuccessful", UpdateToolDraftDtoType.TransferSuccessful },
        { "handoff", UpdateToolDraftDtoType.Handoff },
        { "output", UpdateToolDraftDtoType.Output },
        { "voicemail", UpdateToolDraftDtoType.Voicemail },
        { "query", UpdateToolDraftDtoType.Query },
        { "sms", UpdateToolDraftDtoType.Sms },
        { "sipRequest", UpdateToolDraftDtoType.SipRequest },
        { "function", UpdateToolDraftDtoType.Function },
        { "mcp", UpdateToolDraftDtoType.Mcp },
        { "apiRequest", UpdateToolDraftDtoType.ApiRequest },
        { "code", UpdateToolDraftDtoType.Code },
        { "bash", UpdateToolDraftDtoType.Bash },
        { "computer", UpdateToolDraftDtoType.Computer },
        { "textEditor", UpdateToolDraftDtoType.TextEditor },
        { "google.calendar.event.create", UpdateToolDraftDtoType.GoogleCalendarEventCreate },
        {
            "google.calendar.availability.check",
            UpdateToolDraftDtoType.GoogleCalendarAvailabilityCheck
        },
        { "google.sheets.row.append", UpdateToolDraftDtoType.GoogleSheetsRowAppend },
        { "slack.message.send", UpdateToolDraftDtoType.SlackMessageSend },
        {
            "gohighlevel.calendar.event.create",
            UpdateToolDraftDtoType.GohighlevelCalendarEventCreate
        },
        {
            "gohighlevel.calendar.availability.check",
            UpdateToolDraftDtoType.GohighlevelCalendarAvailabilityCheck
        },
        { "gohighlevel.contact.create", UpdateToolDraftDtoType.GohighlevelContactCreate },
        { "gohighlevel.contact.get", UpdateToolDraftDtoType.GohighlevelContactGet },
        { "make", UpdateToolDraftDtoType.Make },
        { "ghl", UpdateToolDraftDtoType.Ghl },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateToolDraftDtoType,
        string
    > _enumToString = new()
    {
        { UpdateToolDraftDtoType.Dtmf, "dtmf" },
        { UpdateToolDraftDtoType.EndCall, "endCall" },
        { UpdateToolDraftDtoType.KnowledgeBase, "knowledgeBase" },
        { UpdateToolDraftDtoType.TransferCall, "transferCall" },
        { UpdateToolDraftDtoType.TransferCancel, "transferCancel" },
        { UpdateToolDraftDtoType.TransferSuccessful, "transferSuccessful" },
        { UpdateToolDraftDtoType.Handoff, "handoff" },
        { UpdateToolDraftDtoType.Output, "output" },
        { UpdateToolDraftDtoType.Voicemail, "voicemail" },
        { UpdateToolDraftDtoType.Query, "query" },
        { UpdateToolDraftDtoType.Sms, "sms" },
        { UpdateToolDraftDtoType.SipRequest, "sipRequest" },
        { UpdateToolDraftDtoType.Function, "function" },
        { UpdateToolDraftDtoType.Mcp, "mcp" },
        { UpdateToolDraftDtoType.ApiRequest, "apiRequest" },
        { UpdateToolDraftDtoType.Code, "code" },
        { UpdateToolDraftDtoType.Bash, "bash" },
        { UpdateToolDraftDtoType.Computer, "computer" },
        { UpdateToolDraftDtoType.TextEditor, "textEditor" },
        { UpdateToolDraftDtoType.GoogleCalendarEventCreate, "google.calendar.event.create" },
        {
            UpdateToolDraftDtoType.GoogleCalendarAvailabilityCheck,
            "google.calendar.availability.check"
        },
        { UpdateToolDraftDtoType.GoogleSheetsRowAppend, "google.sheets.row.append" },
        { UpdateToolDraftDtoType.SlackMessageSend, "slack.message.send" },
        {
            UpdateToolDraftDtoType.GohighlevelCalendarEventCreate,
            "gohighlevel.calendar.event.create"
        },
        {
            UpdateToolDraftDtoType.GohighlevelCalendarAvailabilityCheck,
            "gohighlevel.calendar.availability.check"
        },
        { UpdateToolDraftDtoType.GohighlevelContactCreate, "gohighlevel.contact.create" },
        { UpdateToolDraftDtoType.GohighlevelContactGet, "gohighlevel.contact.get" },
        { UpdateToolDraftDtoType.Make, "make" },
        { UpdateToolDraftDtoType.Ghl, "ghl" },
    };

    public override UpdateToolDraftDtoType Read(
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
        UpdateToolDraftDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateToolDraftDtoType ReadAsPropertyName(
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
        UpdateToolDraftDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
