using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnalyticsQueryTableSerializer))]
public enum AnalyticsQueryTable
{
    [EnumMember(Value = "call")]
    Call,

    [EnumMember(Value = "subscription")]
    Subscription,
}

internal class AnalyticsQueryTableSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnalyticsQueryTable>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnalyticsQueryTable
    > _stringToEnum = new()
    {
        { "call", AnalyticsQueryTable.Call },
        { "subscription", AnalyticsQueryTable.Subscription },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnalyticsQueryTable,
        string
    > _enumToString = new()
    {
        { AnalyticsQueryTable.Call, "call" },
        { AnalyticsQueryTable.Subscription, "subscription" },
    };

    public override AnalyticsQueryTable Read(
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
        AnalyticsQueryTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnalyticsQueryTable ReadAsPropertyName(
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
        AnalyticsQueryTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
