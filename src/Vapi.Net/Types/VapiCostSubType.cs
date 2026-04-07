using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiCostSubTypeSerializer))]
public enum VapiCostSubType
{
    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "overage")]
    Overage,
}

internal class VapiCostSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiCostSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiCostSubType
    > _stringToEnum = new()
    {
        { "normal", VapiCostSubType.Normal },
        { "overage", VapiCostSubType.Overage },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiCostSubType,
        string
    > _enumToString = new()
    {
        { VapiCostSubType.Normal, "normal" },
        { VapiCostSubType.Overage, "overage" },
    };

    public override VapiCostSubType Read(
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
        VapiCostSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiCostSubType ReadAsPropertyName(
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
        VapiCostSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
