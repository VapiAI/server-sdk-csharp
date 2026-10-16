using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ModelDeprecationNoticeReplacementStatusSerializer))]
public enum ModelDeprecationNoticeReplacementStatus
{
    [EnumMember(Value = "available")]
    Available,

    [EnumMember(Value = "manual-action-required")]
    ManualActionRequired,
}

internal class ModelDeprecationNoticeReplacementStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ModelDeprecationNoticeReplacementStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ModelDeprecationNoticeReplacementStatus
    > _stringToEnum = new()
    {
        { "available", ModelDeprecationNoticeReplacementStatus.Available },
        { "manual-action-required", ModelDeprecationNoticeReplacementStatus.ManualActionRequired },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ModelDeprecationNoticeReplacementStatus,
        string
    > _enumToString = new()
    {
        { ModelDeprecationNoticeReplacementStatus.Available, "available" },
        { ModelDeprecationNoticeReplacementStatus.ManualActionRequired, "manual-action-required" },
    };

    public override ModelDeprecationNoticeReplacementStatus Read(
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
        ModelDeprecationNoticeReplacementStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ModelDeprecationNoticeReplacementStatus ReadAsPropertyName(
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
        ModelDeprecationNoticeReplacementStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
