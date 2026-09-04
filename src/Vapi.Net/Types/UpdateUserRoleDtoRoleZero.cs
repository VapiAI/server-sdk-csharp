using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateUserRoleDtoRoleZeroSerializer))]
public enum UpdateUserRoleDtoRoleZero
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}

internal class UpdateUserRoleDtoRoleZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateUserRoleDtoRoleZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateUserRoleDtoRoleZero
    > _stringToEnum = new()
    {
        { "admin", UpdateUserRoleDtoRoleZero.Admin },
        { "editor", UpdateUserRoleDtoRoleZero.Editor },
        { "viewer", UpdateUserRoleDtoRoleZero.Viewer },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateUserRoleDtoRoleZero,
        string
    > _enumToString = new()
    {
        { UpdateUserRoleDtoRoleZero.Admin, "admin" },
        { UpdateUserRoleDtoRoleZero.Editor, "editor" },
        { UpdateUserRoleDtoRoleZero.Viewer, "viewer" },
    };

    public override UpdateUserRoleDtoRoleZero Read(
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
        UpdateUserRoleDtoRoleZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateUserRoleDtoRoleZero ReadAsPropertyName(
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
        UpdateUserRoleDtoRoleZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
