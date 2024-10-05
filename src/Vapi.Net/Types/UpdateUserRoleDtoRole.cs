using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<UpdateUserRoleDtoRole>))]
public enum UpdateUserRoleDtoRole
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}