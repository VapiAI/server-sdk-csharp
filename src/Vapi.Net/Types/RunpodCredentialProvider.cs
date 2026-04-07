using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RunpodCredentialProviderSerializer))]
public enum RunpodCredentialProvider
{
    [EnumMember(Value = "runpod")]
    Runpod,
}

internal class RunpodCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RunpodCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RunpodCredentialProvider
    > _stringToEnum = new() { { "runpod", RunpodCredentialProvider.Runpod } };

    private static readonly global::System.Collections.Generic.Dictionary<
        RunpodCredentialProvider,
        string
    > _enumToString = new() { { RunpodCredentialProvider.Runpod, "runpod" } };

    public override RunpodCredentialProvider Read(
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
        RunpodCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RunpodCredentialProvider ReadAsPropertyName(
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
        RunpodCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
