using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackPlayHtVoiceIdEnumSerializer))]
public enum FallbackPlayHtVoiceIdEnum
{
    [EnumMember(Value = "jennifer")]
    Jennifer,

    [EnumMember(Value = "melissa")]
    Melissa,

    [EnumMember(Value = "will")]
    Will,

    [EnumMember(Value = "chris")]
    Chris,

    [EnumMember(Value = "matt")]
    Matt,

    [EnumMember(Value = "jack")]
    Jack,

    [EnumMember(Value = "ruby")]
    Ruby,

    [EnumMember(Value = "davis")]
    Davis,

    [EnumMember(Value = "donna")]
    Donna,

    [EnumMember(Value = "michael")]
    Michael,
}

internal class FallbackPlayHtVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackPlayHtVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackPlayHtVoiceIdEnum
    > _stringToEnum = new()
    {
        { "jennifer", FallbackPlayHtVoiceIdEnum.Jennifer },
        { "melissa", FallbackPlayHtVoiceIdEnum.Melissa },
        { "will", FallbackPlayHtVoiceIdEnum.Will },
        { "chris", FallbackPlayHtVoiceIdEnum.Chris },
        { "matt", FallbackPlayHtVoiceIdEnum.Matt },
        { "jack", FallbackPlayHtVoiceIdEnum.Jack },
        { "ruby", FallbackPlayHtVoiceIdEnum.Ruby },
        { "davis", FallbackPlayHtVoiceIdEnum.Davis },
        { "donna", FallbackPlayHtVoiceIdEnum.Donna },
        { "michael", FallbackPlayHtVoiceIdEnum.Michael },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackPlayHtVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { FallbackPlayHtVoiceIdEnum.Jennifer, "jennifer" },
        { FallbackPlayHtVoiceIdEnum.Melissa, "melissa" },
        { FallbackPlayHtVoiceIdEnum.Will, "will" },
        { FallbackPlayHtVoiceIdEnum.Chris, "chris" },
        { FallbackPlayHtVoiceIdEnum.Matt, "matt" },
        { FallbackPlayHtVoiceIdEnum.Jack, "jack" },
        { FallbackPlayHtVoiceIdEnum.Ruby, "ruby" },
        { FallbackPlayHtVoiceIdEnum.Davis, "davis" },
        { FallbackPlayHtVoiceIdEnum.Donna, "donna" },
        { FallbackPlayHtVoiceIdEnum.Michael, "michael" },
    };

    public override FallbackPlayHtVoiceIdEnum Read(
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
        FallbackPlayHtVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackPlayHtVoiceIdEnum ReadAsPropertyName(
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
        FallbackPlayHtVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
