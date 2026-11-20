using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationSuiteControllerFindAllRequestSortBySerializer))]
public enum SimulationSuiteControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class SimulationSuiteControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationSuiteControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationSuiteControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", SimulationSuiteControllerFindAllRequestSortBy.CreatedAt },
        { "duration", SimulationSuiteControllerFindAllRequestSortBy.Duration },
        { "cost", SimulationSuiteControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationSuiteControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { SimulationSuiteControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { SimulationSuiteControllerFindAllRequestSortBy.Duration, "duration" },
        { SimulationSuiteControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override SimulationSuiteControllerFindAllRequestSortBy Read(
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
        SimulationSuiteControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationSuiteControllerFindAllRequestSortBy ReadAsPropertyName(
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
        SimulationSuiteControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
