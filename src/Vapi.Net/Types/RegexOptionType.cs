using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RegexOptionTypeSerializer))]
public enum RegexOptionType
{
    [EnumMember(Value = "ignore-case")]
    IgnoreCase,

    [EnumMember(Value = "whole-word")]
    WholeWord,

    [EnumMember(Value = "multi-line")]
    MultiLine,
}

internal class RegexOptionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RegexOptionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RegexOptionType
    > _stringToEnum = new()
    {
        { "ignore-case", RegexOptionType.IgnoreCase },
        { "whole-word", RegexOptionType.WholeWord },
        { "multi-line", RegexOptionType.MultiLine },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RegexOptionType,
        string
    > _enumToString = new()
    {
        { RegexOptionType.IgnoreCase, "ignore-case" },
        { RegexOptionType.WholeWord, "whole-word" },
        { RegexOptionType.MultiLine, "multi-line" },
    };

    public override RegexOptionType Read(
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
        RegexOptionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RegexOptionType ReadAsPropertyName(
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
        RegexOptionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
