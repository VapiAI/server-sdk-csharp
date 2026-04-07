using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaCredentialProviderSerializer))]
public enum CartesiaCredentialProvider
{
    [EnumMember(Value = "cartesia")]
    Cartesia,
}

internal class CartesiaCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaCredentialProvider
    > _stringToEnum = new() { { "cartesia", CartesiaCredentialProvider.Cartesia } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaCredentialProvider,
        string
    > _enumToString = new() { { CartesiaCredentialProvider.Cartesia, "cartesia" } };

    public override CartesiaCredentialProvider Read(
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
        CartesiaCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaCredentialProvider ReadAsPropertyName(
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
        CartesiaCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
