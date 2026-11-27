using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GetTrafficTabMetricsDtoBucketSerializer))]
public enum GetTrafficTabMetricsDtoBucket
{
    [EnumMember(Value = "hour")]
    Hour,

    [EnumMember(Value = "day")]
    Day,
}

internal class GetTrafficTabMetricsDtoBucketSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GetTrafficTabMetricsDtoBucket>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GetTrafficTabMetricsDtoBucket
    > _stringToEnum = new()
    {
        { "hour", GetTrafficTabMetricsDtoBucket.Hour },
        { "day", GetTrafficTabMetricsDtoBucket.Day },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GetTrafficTabMetricsDtoBucket,
        string
    > _enumToString = new()
    {
        { GetTrafficTabMetricsDtoBucket.Hour, "hour" },
        { GetTrafficTabMetricsDtoBucket.Day, "day" },
    };

    public override GetTrafficTabMetricsDtoBucket Read(
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
        GetTrafficTabMetricsDtoBucket value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GetTrafficTabMetricsDtoBucket ReadAsPropertyName(
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
        GetTrafficTabMetricsDtoBucket value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
