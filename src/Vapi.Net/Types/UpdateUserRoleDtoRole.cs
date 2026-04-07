using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateUserRoleDtoRoleSerializer))]
public enum UpdateUserRoleDtoRole
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}

internal class UpdateUserRoleDtoRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateUserRoleDtoRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateUserRoleDtoRole
    > _stringToEnum = new()
    {
        { "admin", UpdateUserRoleDtoRole.Admin },
        { "editor", UpdateUserRoleDtoRole.Editor },
        { "viewer", UpdateUserRoleDtoRole.Viewer },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateUserRoleDtoRole,
        string
    > _enumToString = new()
    {
        { UpdateUserRoleDtoRole.Admin, "admin" },
        { UpdateUserRoleDtoRole.Editor, "editor" },
        { UpdateUserRoleDtoRole.Viewer, "viewer" },
    };

    public override UpdateUserRoleDtoRole Read(
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
        UpdateUserRoleDtoRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateUserRoleDtoRole ReadAsPropertyName(
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
        UpdateUserRoleDtoRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
