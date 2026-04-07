using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeveloperMessageRoleSerializer))]
public enum DeveloperMessageRole
{
    [EnumMember(Value = "developer")]
    Developer,
}

internal class DeveloperMessageRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeveloperMessageRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeveloperMessageRole
    > _stringToEnum = new() { { "developer", DeveloperMessageRole.Developer } };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeveloperMessageRole,
        string
    > _enumToString = new() { { DeveloperMessageRole.Developer, "developer" } };

    public override DeveloperMessageRole Read(
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
        DeveloperMessageRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeveloperMessageRole ReadAsPropertyName(
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
        DeveloperMessageRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
