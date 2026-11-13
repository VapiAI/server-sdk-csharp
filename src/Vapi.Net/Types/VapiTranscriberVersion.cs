using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiTranscriberVersionSerializer))]
public enum VapiTranscriberVersion
{
    [EnumMember(Value = "latest")]
    Latest,

    [EnumMember(Value = "1")]
    One,
}

internal class VapiTranscriberVersionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiTranscriberVersion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiTranscriberVersion
    > _stringToEnum = new()
    {
        { "latest", VapiTranscriberVersion.Latest },
        { "1", VapiTranscriberVersion.One },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiTranscriberVersion,
        string
    > _enumToString = new()
    {
        { VapiTranscriberVersion.Latest, "latest" },
        { VapiTranscriberVersion.One, "1" },
    };

    public override VapiTranscriberVersion Read(
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
        VapiTranscriberVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiTranscriberVersion ReadAsPropertyName(
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
        VapiTranscriberVersion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
