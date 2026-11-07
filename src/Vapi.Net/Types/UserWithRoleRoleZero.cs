using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UserWithRoleRoleZeroSerializer))]
public enum UserWithRoleRoleZero
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,

    [EnumMember(Value = "hipaa-special")]
    HipaaSpecial,
}

internal class UserWithRoleRoleZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UserWithRoleRoleZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UserWithRoleRoleZero
    > _stringToEnum = new()
    {
        { "admin", UserWithRoleRoleZero.Admin },
        { "editor", UserWithRoleRoleZero.Editor },
        { "viewer", UserWithRoleRoleZero.Viewer },
        { "hipaa-special", UserWithRoleRoleZero.HipaaSpecial },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UserWithRoleRoleZero,
        string
    > _enumToString = new()
    {
        { UserWithRoleRoleZero.Admin, "admin" },
        { UserWithRoleRoleZero.Editor, "editor" },
        { UserWithRoleRoleZero.Viewer, "viewer" },
        { UserWithRoleRoleZero.HipaaSpecial, "hipaa-special" },
    };

    public override UserWithRoleRoleZero Read(
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
        UserWithRoleRoleZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UserWithRoleRoleZero ReadAsPropertyName(
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
        UserWithRoleRoleZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
