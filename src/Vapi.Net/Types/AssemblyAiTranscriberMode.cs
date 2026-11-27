using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssemblyAiTranscriberModeSerializer))]
public enum AssemblyAiTranscriberMode
{
    [EnumMember(Value = "max_accuracy")]
    MaxAccuracy,

    [EnumMember(Value = "min_latency")]
    MinLatency,

    [EnumMember(Value = "balanced")]
    Balanced,
}

internal class AssemblyAiTranscriberModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssemblyAiTranscriberMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssemblyAiTranscriberMode
    > _stringToEnum = new()
    {
        { "max_accuracy", AssemblyAiTranscriberMode.MaxAccuracy },
        { "min_latency", AssemblyAiTranscriberMode.MinLatency },
        { "balanced", AssemblyAiTranscriberMode.Balanced },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssemblyAiTranscriberMode,
        string
    > _enumToString = new()
    {
        { AssemblyAiTranscriberMode.MaxAccuracy, "max_accuracy" },
        { AssemblyAiTranscriberMode.MinLatency, "min_latency" },
        { AssemblyAiTranscriberMode.Balanced, "balanced" },
    };

    public override AssemblyAiTranscriberMode Read(
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
        AssemblyAiTranscriberMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssemblyAiTranscriberMode ReadAsPropertyName(
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
        AssemblyAiTranscriberMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
