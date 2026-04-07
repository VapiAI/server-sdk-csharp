using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GladiaTranscriberRegionSerializer))]
public enum GladiaTranscriberRegion
{
    [EnumMember(Value = "us-west")]
    UsWest,

    [EnumMember(Value = "eu-west")]
    EuWest,
}

internal class GladiaTranscriberRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GladiaTranscriberRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GladiaTranscriberRegion
    > _stringToEnum = new()
    {
        { "us-west", GladiaTranscriberRegion.UsWest },
        { "eu-west", GladiaTranscriberRegion.EuWest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GladiaTranscriberRegion,
        string
    > _enumToString = new()
    {
        { GladiaTranscriberRegion.UsWest, "us-west" },
        { GladiaTranscriberRegion.EuWest, "eu-west" },
    };

    public override GladiaTranscriberRegion Read(
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
        GladiaTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GladiaTranscriberRegion ReadAsPropertyName(
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
        GladiaTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
