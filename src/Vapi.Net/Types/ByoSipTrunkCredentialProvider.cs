using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ByoSipTrunkCredentialProviderSerializer))]
public enum ByoSipTrunkCredentialProvider
{
    [EnumMember(Value = "byo-sip-trunk")]
    ByoSipTrunk,
}

internal class ByoSipTrunkCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ByoSipTrunkCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ByoSipTrunkCredentialProvider
    > _stringToEnum = new() { { "byo-sip-trunk", ByoSipTrunkCredentialProvider.ByoSipTrunk } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ByoSipTrunkCredentialProvider,
        string
    > _enumToString = new() { { ByoSipTrunkCredentialProvider.ByoSipTrunk, "byo-sip-trunk" } };

    public override ByoSipTrunkCredentialProvider Read(
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
        ByoSipTrunkCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ByoSipTrunkCredentialProvider ReadAsPropertyName(
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
        ByoSipTrunkCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
