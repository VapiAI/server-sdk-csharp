using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CerebrasModelModelSerializer))]
public enum CerebrasModelModel
{
    [EnumMember(Value = "llama3.1-8b")]
    Llama318B,

    [EnumMember(Value = "llama-3.3-70b")]
    Llama3370B,
}

internal class CerebrasModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CerebrasModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CerebrasModelModel
    > _stringToEnum = new()
    {
        { "llama3.1-8b", CerebrasModelModel.Llama318B },
        { "llama-3.3-70b", CerebrasModelModel.Llama3370B },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CerebrasModelModel,
        string
    > _enumToString = new()
    {
        { CerebrasModelModel.Llama318B, "llama3.1-8b" },
        { CerebrasModelModel.Llama3370B, "llama-3.3-70b" },
    };

    public override CerebrasModelModel Read(
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
        CerebrasModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CerebrasModelModel ReadAsPropertyName(
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
        CerebrasModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
