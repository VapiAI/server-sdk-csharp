using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAssemblyAiTranscriberModeSerializer))]
public enum FallbackAssemblyAiTranscriberMode
{
    [EnumMember(Value = "max_accuracy")]
    MaxAccuracy,

    [EnumMember(Value = "min_latency")]
    MinLatency,

    [EnumMember(Value = "balanced")]
    Balanced,
}

internal class FallbackAssemblyAiTranscriberModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAssemblyAiTranscriberMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAssemblyAiTranscriberMode
    > _stringToEnum = new()
    {
        { "max_accuracy", FallbackAssemblyAiTranscriberMode.MaxAccuracy },
        { "min_latency", FallbackAssemblyAiTranscriberMode.MinLatency },
        { "balanced", FallbackAssemblyAiTranscriberMode.Balanced },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAssemblyAiTranscriberMode,
        string
    > _enumToString = new()
    {
        { FallbackAssemblyAiTranscriberMode.MaxAccuracy, "max_accuracy" },
        { FallbackAssemblyAiTranscriberMode.MinLatency, "min_latency" },
        { FallbackAssemblyAiTranscriberMode.Balanced, "balanced" },
    };

    public override FallbackAssemblyAiTranscriberMode Read(
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
        FallbackAssemblyAiTranscriberMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAssemblyAiTranscriberMode ReadAsPropertyName(
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
        FallbackAssemblyAiTranscriberMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
