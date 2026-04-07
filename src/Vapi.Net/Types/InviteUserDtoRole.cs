using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InviteUserDtoRoleSerializer))]
public enum InviteUserDtoRole
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}

internal class InviteUserDtoRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InviteUserDtoRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InviteUserDtoRole
    > _stringToEnum = new()
    {
        { "admin", InviteUserDtoRole.Admin },
        { "editor", InviteUserDtoRole.Editor },
        { "viewer", InviteUserDtoRole.Viewer },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InviteUserDtoRole,
        string
    > _enumToString = new()
    {
        { InviteUserDtoRole.Admin, "admin" },
        { InviteUserDtoRole.Editor, "editor" },
        { InviteUserDtoRole.Viewer, "viewer" },
    };

    public override InviteUserDtoRole Read(
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
        InviteUserDtoRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InviteUserDtoRole ReadAsPropertyName(
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
        InviteUserDtoRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
