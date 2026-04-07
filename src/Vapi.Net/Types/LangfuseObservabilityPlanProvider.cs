using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LangfuseObservabilityPlanProviderSerializer))]
public enum LangfuseObservabilityPlanProvider
{
    [EnumMember(Value = "langfuse")]
    Langfuse,
}

internal class LangfuseObservabilityPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LangfuseObservabilityPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LangfuseObservabilityPlanProvider
    > _stringToEnum = new() { { "langfuse", LangfuseObservabilityPlanProvider.Langfuse } };

    private static readonly global::System.Collections.Generic.Dictionary<
        LangfuseObservabilityPlanProvider,
        string
    > _enumToString = new() { { LangfuseObservabilityPlanProvider.Langfuse, "langfuse" } };

    public override LangfuseObservabilityPlanProvider Read(
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
        LangfuseObservabilityPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LangfuseObservabilityPlanProvider ReadAsPropertyName(
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
        LangfuseObservabilityPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
