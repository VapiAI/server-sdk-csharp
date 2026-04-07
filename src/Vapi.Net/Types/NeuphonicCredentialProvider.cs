using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(NeuphonicCredentialProviderSerializer))]
public enum NeuphonicCredentialProvider
{
    [EnumMember(Value = "neuphonic")]
    Neuphonic,
}

internal class NeuphonicCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<NeuphonicCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        NeuphonicCredentialProvider
    > _stringToEnum = new() { { "neuphonic", NeuphonicCredentialProvider.Neuphonic } };

    private static readonly global::System.Collections.Generic.Dictionary<
        NeuphonicCredentialProvider,
        string
    > _enumToString = new() { { NeuphonicCredentialProvider.Neuphonic, "neuphonic" } };

    public override NeuphonicCredentialProvider Read(
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
        NeuphonicCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override NeuphonicCredentialProvider ReadAsPropertyName(
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
        NeuphonicCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
