using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateUserRoleDtoRole>))]
public enum UpdateUserRoleDtoRole
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}
