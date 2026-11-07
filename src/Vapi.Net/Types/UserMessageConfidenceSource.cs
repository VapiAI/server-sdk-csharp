using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UserMessageConfidenceSourceSerializer))]
public enum UserMessageConfidenceSource
{
    [EnumMember(Value = "provider")]
    Provider,

    [EnumMember(Value = "derived")]
    Derived,
}

internal class UserMessageConfidenceSourceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UserMessageConfidenceSource>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UserMessageConfidenceSource
    > _stringToEnum = new()
    {
        { "provider", UserMessageConfidenceSource.Provider },
        { "derived", UserMessageConfidenceSource.Derived },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UserMessageConfidenceSource,
        string
    > _enumToString = new()
    {
        { UserMessageConfidenceSource.Provider, "provider" },
        { UserMessageConfidenceSource.Derived, "derived" },
    };

    public override UserMessageConfidenceSource Read(
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
        UserMessageConfidenceSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UserMessageConfidenceSource ReadAsPropertyName(
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
        UserMessageConfidenceSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
