using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InviteUserDtoRoleZeroSerializer))]
public enum InviteUserDtoRoleZero
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}

internal class InviteUserDtoRoleZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InviteUserDtoRoleZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InviteUserDtoRoleZero
    > _stringToEnum = new()
    {
        { "admin", InviteUserDtoRoleZero.Admin },
        { "editor", InviteUserDtoRoleZero.Editor },
        { "viewer", InviteUserDtoRoleZero.Viewer },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InviteUserDtoRoleZero,
        string
    > _enumToString = new()
    {
        { InviteUserDtoRoleZero.Admin, "admin" },
        { InviteUserDtoRoleZero.Editor, "editor" },
        { InviteUserDtoRoleZero.Viewer, "viewer" },
    };

    public override InviteUserDtoRoleZero Read(
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
        InviteUserDtoRoleZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InviteUserDtoRoleZero ReadAsPropertyName(
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
        InviteUserDtoRoleZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
