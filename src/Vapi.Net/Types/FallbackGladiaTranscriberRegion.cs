using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGladiaTranscriberRegionSerializer))]
public enum FallbackGladiaTranscriberRegion
{
    [EnumMember(Value = "us-west")]
    UsWest,

    [EnumMember(Value = "eu-west")]
    EuWest,
}

internal class FallbackGladiaTranscriberRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGladiaTranscriberRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGladiaTranscriberRegion
    > _stringToEnum = new()
    {
        { "us-west", FallbackGladiaTranscriberRegion.UsWest },
        { "eu-west", FallbackGladiaTranscriberRegion.EuWest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGladiaTranscriberRegion,
        string
    > _enumToString = new()
    {
        { FallbackGladiaTranscriberRegion.UsWest, "us-west" },
        { FallbackGladiaTranscriberRegion.EuWest, "eu-west" },
    };

    public override FallbackGladiaTranscriberRegion Read(
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
        FallbackGladiaTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGladiaTranscriberRegion ReadAsPropertyName(
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
        FallbackGladiaTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
