using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackXaiTranscriberModelSerializer))]
public enum FallbackXaiTranscriberModel
{
    [EnumMember(Value = "default")]
    Default,
}

internal class FallbackXaiTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackXaiTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackXaiTranscriberModel
    > _stringToEnum = new() { { "default", FallbackXaiTranscriberModel.Default } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackXaiTranscriberModel,
        string
    > _enumToString = new() { { FallbackXaiTranscriberModel.Default, "default" } };

    public override FallbackXaiTranscriberModel Read(
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
        FallbackXaiTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackXaiTranscriberModel ReadAsPropertyName(
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
        FallbackXaiTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
