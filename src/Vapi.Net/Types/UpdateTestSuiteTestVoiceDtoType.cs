using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateTestSuiteTestVoiceDtoTypeSerializer))]
public enum UpdateTestSuiteTestVoiceDtoType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class UpdateTestSuiteTestVoiceDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateTestSuiteTestVoiceDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateTestSuiteTestVoiceDtoType
    > _stringToEnum = new() { { "voice", UpdateTestSuiteTestVoiceDtoType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateTestSuiteTestVoiceDtoType,
        string
    > _enumToString = new() { { UpdateTestSuiteTestVoiceDtoType.Voice, "voice" } };

    public override UpdateTestSuiteTestVoiceDtoType Read(
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
        UpdateTestSuiteTestVoiceDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateTestSuiteTestVoiceDtoType ReadAsPropertyName(
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
        UpdateTestSuiteTestVoiceDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
