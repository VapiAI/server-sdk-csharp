using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationControllerFindAllRequestSortBySerializer))]
public enum SimulationControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class SimulationControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", SimulationControllerFindAllRequestSortBy.CreatedAt },
        { "duration", SimulationControllerFindAllRequestSortBy.Duration },
        { "cost", SimulationControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { SimulationControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { SimulationControllerFindAllRequestSortBy.Duration, "duration" },
        { SimulationControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override SimulationControllerFindAllRequestSortBy Read(
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
        SimulationControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationControllerFindAllRequestSortBy ReadAsPropertyName(
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
        SimulationControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
