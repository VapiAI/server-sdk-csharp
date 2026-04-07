using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SupabaseCredentialProviderSerializer))]
public enum SupabaseCredentialProvider
{
    [EnumMember(Value = "supabase")]
    Supabase,
}

internal class SupabaseCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SupabaseCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SupabaseCredentialProvider
    > _stringToEnum = new() { { "supabase", SupabaseCredentialProvider.Supabase } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SupabaseCredentialProvider,
        string
    > _enumToString = new() { { SupabaseCredentialProvider.Supabase, "supabase" } };

    public override SupabaseCredentialProvider Read(
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
        SupabaseCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SupabaseCredentialProvider ReadAsPropertyName(
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
        SupabaseCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
