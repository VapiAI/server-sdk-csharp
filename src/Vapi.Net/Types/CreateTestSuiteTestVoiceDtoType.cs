using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateTestSuiteTestVoiceDtoTypeSerializer))]
public enum CreateTestSuiteTestVoiceDtoType
{
    [EnumMember(Value = "voice")]
    Voice,
}

internal class CreateTestSuiteTestVoiceDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateTestSuiteTestVoiceDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateTestSuiteTestVoiceDtoType
    > _stringToEnum = new() { { "voice", CreateTestSuiteTestVoiceDtoType.Voice } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateTestSuiteTestVoiceDtoType,
        string
    > _enumToString = new() { { CreateTestSuiteTestVoiceDtoType.Voice, "voice" } };

    public override CreateTestSuiteTestVoiceDtoType Read(
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
        CreateTestSuiteTestVoiceDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateTestSuiteTestVoiceDtoType ReadAsPropertyName(
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
        CreateTestSuiteTestVoiceDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
