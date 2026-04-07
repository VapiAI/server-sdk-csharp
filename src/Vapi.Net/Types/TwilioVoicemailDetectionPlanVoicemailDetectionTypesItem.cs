using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TwilioVoicemailDetectionPlanVoicemailDetectionTypesItemSerializer))]
public enum TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem
{
    [EnumMember(Value = "machine_start")]
    MachineStart,

    [EnumMember(Value = "human")]
    Human,

    [EnumMember(Value = "fax")]
    Fax,

    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "machine_end_beep")]
    MachineEndBeep,

    [EnumMember(Value = "machine_end_silence")]
    MachineEndSilence,

    [EnumMember(Value = "machine_end_other")]
    MachineEndOther,
}

internal class TwilioVoicemailDetectionPlanVoicemailDetectionTypesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem
    > _stringToEnum = new()
    {
        { "machine_start", TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineStart },
        { "human", TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.Human },
        { "fax", TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.Fax },
        { "unknown", TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.Unknown },
        {
            "machine_end_beep",
            TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineEndBeep
        },
        {
            "machine_end_silence",
            TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineEndSilence
        },
        {
            "machine_end_other",
            TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineEndOther
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem,
        string
    > _enumToString = new()
    {
        { TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineStart, "machine_start" },
        { TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.Human, "human" },
        { TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.Fax, "fax" },
        { TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.Unknown, "unknown" },
        {
            TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineEndBeep,
            "machine_end_beep"
        },
        {
            TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineEndSilence,
            "machine_end_silence"
        },
        {
            TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem.MachineEndOther,
            "machine_end_other"
        },
    };

    public override TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem Read(
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
        TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem ReadAsPropertyName(
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
        TwilioVoicemailDetectionPlanVoicemailDetectionTypesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
